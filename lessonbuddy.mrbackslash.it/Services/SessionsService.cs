using Models = lessonbuddy.mrbackslash.it.Models;
using Entities = lessonbuddy.mrbackslash.it.Entities;
using Formats = lessonbuddy.mrbackslash.it.Formats;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.AspNetCore.Components.Forms;
using System;
using lessonbuddy.mrbackslash.it.Helpers;
using System.IO;
using System.IO.Compression;
using System.Text.Json;
using System.Threading.Tasks;

namespace lessonbuddy.mrbackslash.it.Services
{
    public class SessionsService
    {
        private readonly Models.LessonBuddyContext _context;
        public SessionsService(Models.LessonBuddyContext context)
        {
            _context = context;
        }

        public List<Entities.Session> GetAll()
        {
            return _context.Sessions.Select
            (
                s => new Entities.Session
                {
                    Idsession = s.Idsession,
                    Guidsession = s.Guidsession,
                    Username = s.Username,
                    Subject = s.Subject,
                    Location = s.Location,
                    UploadDateTime = s.UploadDateTime,
                    Payloads = _context.Payloads.Where(p => p.Idsession == s.Idsession).Select
                    (
                        p => new Entities.Payload
                        {
                            Idsession = p.Idsession,
                            EventTime = p.EventTime,
                            ConnectionStrength = p.ConnectionStrength,
                            AttentionLevel = p.AttentionLevel,
                            MeditationLevel = p.MeditationLevel
                        }
                    ).ToList()
                }
            ).ToList();
        }

        public Entities.Session Get(int id)
        {
            return _context.Sessions.Where(s => s.Idsession == id).Select
            (
                s => new Entities.Session
                {
                    Idsession = s.Idsession,
                    Guidsession = s.Guidsession,
                    Username = s.Username,
                    Subject = s.Subject,
                    Location = s.Location,
                    UploadDateTime = s.UploadDateTime,
                    Payloads = _context.Payloads.Where(p => p.Idsession == s.Idsession).Select
                    (
                        p => new Entities.Payload
                        {
                            Idsession = p.Idsession,
                            EventTime = p.EventTime,
                            ConnectionStrength = p.ConnectionStrength,
                            AttentionLevel = p.AttentionLevel,
                            MeditationLevel = p.MeditationLevel
                        }
                    ).ToList()
                }
            ).Single();
        }

        public Entities.Session Update(Entities.Session entity)
        {
            Models.Session model = _context.Sessions.Where(s => s.Idsession == entity.Idsession).Single();

            model.Guidsession = entity.Guidsession;
            model.Username = entity.Username;
            model.Subject = entity.Subject;
            model.Location = entity.Location;
            model.UploadDateTime = entity.UploadDateTime.Value;           

            _ = _context.Sessions.Update(model);
            _context.SaveChanges();

            return Get(entity.Idsession);
        }

        public Entities.Session Insert(Entities.Session item)
        {
            Models.Session model = new Models.Session
            {
                Guidsession = item.Guidsession,
                Username = item.Username,
                Subject = item.Subject,
                Location = item.Location,
                UploadDateTime = item.UploadDateTime.Value
            };

            _ = _context.Sessions.Add(model);
            _context.SaveChanges();

            List<Models.Payload> children = new List<Models.Payload>();

            children = item.Payloads.Select
            (
                p => new Models.Payload
                {
                    Idsession = model.Idsession,
                    EventTime = p.EventTime,
                    ConnectionStrength = p.ConnectionStrength,
                    AttentionLevel = p.AttentionLevel,
                    MeditationLevel = p.MeditationLevel
                }
            ).ToList();

            _context.Payloads.AddRange(children);
            _context.SaveChanges();

            return Get(model.Idsession);
        }

        public bool Delete(Entities.Session item)
        {
            Models.Session model = _context.Sessions.Where(s => s.Idsession == item.Idsession).Single();

            _ = _context.Remove(model);
            return (_context.SaveChanges() == 1);
        }

        public async Task<string> Upload
        (
            IBrowserFile file,
            string username
        )
        {
            string result = "Sessione caricata correttamente";

            if (file.Name.StartsWith("LB-"))
            {
                string fileTimestampFragment = file.Name.Substring(3, file.Name.IndexOf(".") - 3);
                DateTime fileTimestamp;

                if (DateTime.TryParseExact(fileTimestampFragment, "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.AssumeLocal, out fileTimestamp))
                {
                    try
                    {
                        string secretMD5Hash = MD5Helper.CreateMD5(fileTimestampFragment);

                        string path = Path.GetFullPath("Uploads");

                        path = path + "\\" + file.Name;
                        await using FileStream fs = new(path, FileMode.Create);
                        await file.OpenReadStream().CopyToAsync(fs);

                        using (ZipArchive zippedStream = new ZipArchive(fs))
                        {

                            if (zippedStream.Entries.Count == 1)
                            {
                                ZipArchiveEntry entry = zippedStream.Entries.Single();

                                if (entry.FullName.EndsWith(".json"))
                                {
                                    Stream unzippedStream = entry.Open();

                                    using (StreamReader reader = new StreamReader(unzippedStream))
                                    {
                                        try
                                        {
                                            Formats.LBDFileContentFormat deserializedLDB = JsonSerializer.Deserialize<Formats.LBDFileContentFormat>(await reader.ReadToEndAsync());

                                            if (deserializedLDB.Checksum == secretMD5Hash)
                                            {
                                                if (deserializedLDB.Session != null)
                                                {
                                                    if (deserializedLDB.Session.Payloads != null)
                                                    {
                                                        Entities.Session session = new Entities.Session
                                                        {
                                                            Idsession = 0,
                                                            Guidsession = Guid.NewGuid(),
                                                            Username = username,
                                                            Subject = deserializedLDB.Session.Subject,
                                                            Location = deserializedLDB.Session.Location,
                                                            UploadDateTime = DateTime.Now,
                                                            Payloads = deserializedLDB.Session.Payloads.Select
                                                            (
                                                                p => new Entities.Payload
                                                                {
                                                                    Idsession = 0,
                                                                    EventTime = p.EventTime,
                                                                    ConnectionStrength = p.ConnectionStrength,
                                                                    AttentionLevel = p.AttentionLevel,
                                                                    MeditationLevel = p.MeditationLevel
                                                                }
                                                            ).ToList()
                                                        };

                                                        Insert(session);
                                                    }
                                                    else
                                                    {
                                                        result = "Il contenuto del file non è valido";
                                                    }
                                                }
                                                else
                                                {
                                                    result = "Il contenuto del file non è valido";
                                                }
                                            }
                                            else
                                            {
                                                result = "Il contenuto del file non è valido";
                                            }
                                        }
                                        catch
                                        {
                                            result = "Il contenuto del file non è valido";
                                        }
                                    }
                                }
                                else
                                {
                                    result = "Il contenuto del file non è valido";
                                }
                            }
                            else
                            {
                                result = "Il contenuto del file non è valido";
                            }
                        }

                        File.Delete(path);
                    }
                    catch(Exception e)
                    {
                        result = "Il contenuto del file non è valido";
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    result = "Il nome file non è corretto";
                }
            }
            else
            {
                result = "Il nome file non è corretto";
            }

            return result;
        }
    }
}
