using System;
using System.IO;

namespace AutoRent.Services
{
 public static class Logger
 {
 private static readonly object _lock = new object();
 private static readonly string _logFile = Path.Combine(AppContext.BaseDirectory, "logs", "app.log");

 static Logger()
 {
 try
 {
 var dir = Path.GetDirectoryName(_logFile);
 if (!Directory.Exists(dir)) Directory.CreateDirectory(dir!);
 }
 catch
 {
 // ignore
 }
 }

 public static void Info(string message) => Write("INFO", message);

 public static void Error(string message) => Write("ERROR", message);

 private static void Write(string level, string message)
 {
 try
 {
 lock (_lock)
 {
 File.AppendAllText(_logFile, $"{DateTime.Now:O} [{level}] {message}{Environment.NewLine}");
 }
 }
 catch
 {
 // ignore logging failures
 }
 }
 }
}
