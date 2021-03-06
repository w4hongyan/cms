﻿using ICSharpCode.SharpZipLib.Zip;

namespace SSCMS.Core.Utils
{
	public static class ZipUtils
	{
        public static void CreateZip(string zipFilePath, string directoryPath)
        {
            CreateZip(zipFilePath, directoryPath, string.Empty);
        }

        public static void CreateZip(string zipFilePath, string directoryPath, string fileFilter)
        {
            var fz = new FastZip { CreateEmptyDirectories = true };
            fz.CreateZip(zipFilePath, directoryPath, true, string.Empty);
        }

		public static void ExtractZip(string zipFilePath, string directoryPath)
        {
            var fz = new FastZip();
            fz.ExtractZip(zipFilePath, directoryPath, null);
        }

        //public static void UnpackFilesByExtension(string zipFilePath, string directoryPath, string extension)
        //{
        //    var fz = new FastZip();
        //    fz.ExtractZip(zipFilePath, directoryPath, ".*\\" + extension + "$");
        //}

        //public static bool UnpackFiles(string zipFilePath, string directoryPath)
        //{
        //    if (!Directory.Exists(directoryPath))
        //        Directory.CreateDirectory(directoryPath);

        //    ZipInputStream s = new ZipInputStream(File.OpenRead(zipFilePath));

        //    ZipEntry theEntry;
        //    while ((theEntry = s.GetNextEntry()) != null)
        //    {
        //        string directoryName = Path.GetDirectoryName(theEntry.Name);
        //        string fileName = Path.GetFileName(theEntry.Name);

        //        if (directoryName != string.Empty)
        //            Directory.CreateDirectory(directoryPath + directoryName);

        //        if (fileName != string.Empty)
        //        {
        //            FileStream streamWriter = File.Create(Path.Combine(directoryPath, theEntry.Name));

        //            int size = 2048;
        //            byte[] data = new byte[2048];
        //            while (true)
        //            {
        //                size = s.Read(data, 0, data.Length);
        //                if (size > 0)
        //                {
        //                    streamWriter.Write(data, 0, size);
        //                }
        //                else
        //                {
        //                    break;
        //                }
        //            }

        //            streamWriter.Close();
        //        }
        //    }
        //    s.Close();
        //    return true;
        //}


  //      public static void Zip(string directoryPath, string zipFilePath)
		//{
		//	var filenames = Directory.GetFiles(directoryPath);

		//	var crc = new Crc32();
		//	var s = new ZipOutputStream(File.Create(zipFilePath));

		//	s.SetLevel(6); // 0 - store only to 9 - means best compression

		//	foreach (var file in filenames)
		//	{
		//		var fs = File.OpenRead(file);

		//		var buffer = new byte[fs.Length];
		//		fs.Read(buffer, 0, buffer.Length);
		//	    var entry = new ZipEntry(file)
		//	    {
		//	        DateTime = DateTime.Now,
		//	        Size = fs.Length
		//	    };

		//	    // set Size and the crc, because the information
		//	    // about the size and crc should be stored in the header
		//	    // if it is not set it is automatically written in the footer.
		//	    // (in this case size == crc == -1 in the header)
		//	    // Some ZIP programs have problems with zip files that don't store
		//	    // the size and crc in the header.
		//	    fs.Close();

		//		crc.Reset();
		//		crc.Update(buffer);

		//		entry.Crc = crc.Value;

		//		s.PutNextEntry(entry);

		//		s.Write(buffer, 0, buffer.Length);

		//	}

		//	s.Finish();
		//	s.Close();
		//}


		//public static void UnZip(string directoryPath, string zipFilePath)
		//{
		//	var s = new ZipInputStream(File.OpenRead(zipFilePath));

		//	ZipEntry theEntry;
		//	while ((theEntry = s.GetNextEntry()) != null)
		//	{
		//		var fileInfo = new FileInfo(theEntry.Name);
		//		var fileName = fileInfo.Name;

		//		// create directory
		//		DirectoryUtils.CreateDirectoryIfNotExists(directoryPath);

		//	    if (fileName == string.Empty) continue;

		//	    var filePath = directoryPath + Path.DirectorySeparatorChar + fileName;
		//	    var streamWriter = File.Create(filePath);

		//	    var data = new byte[2048];
		//	    while (true)
		//	    {
		//	        var size = s.Read(data, 0, data.Length);
		//	        if (size > 0)
		//	        {
		//	            streamWriter.Write(data, 0, size);
		//	        }
		//	        else
		//	        {
		//	            break;
		//	        }
		//	    }

		//	    streamWriter.Close();
		//	}
		//	s.Close();
		//}



//		public static void UnZip(string zipFilePath)
//		{
//			ZipInputStream s = new ZipInputStream(File.OpenRead(zipFilePath));
//
//			ZipEntry theEntry;
//			while ((theEntry = s.GetNextEntry()) != null)
//			{
//
//				Console.WriteLine(theEntry.Name);
//
//				string directoryName = Path.GetDirectoryName(theEntry.Name);
//				string fileName = Path.GetFileName(theEntry.Name);
//
//				// create directory
//				Directory.CreateDirectory(directoryName);
//
//				if (fileName != string.Empty)
//				{
//					FileStream streamWriter = File.Create(theEntry.Name);
//
//					int size = 2048;
//					byte[] data = new byte[2048];
//					while (true)
//					{
//						size = s.Read(data, 0, data.Length);
//						if (size > 0)
//						{
//							streamWriter.Write(data, 0, size);
//						}
//						else
//						{
//							break;
//						}
//					}
//
//					streamWriter.Close();
//				}
//			}
//			s.Close();
//		}
	}
}
