using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Dynamic;
using System.Net.Http;

namespace MoverArquivosE
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivos = @"C:\Users\jr\Documents\CARGA_TENS";
            string saida = @"C:\Users\jr\Documents\carga_itensnovo";

            string[] files = Directory.GetFiles(arquivos);

            foreach (var item in files)
            {              
                FileInfo fileInfo = new FileInfo(item);
                string fileName = fileInfo.Name;

                string[] filesSaida = Directory.GetFiles(saida);
                foreach (var itemSaida in filesSaida)
                {
                    FileInfo fileInfoSaida = new FileInfo(itemSaida);
                    string fileNameSaida = fileInfoSaida.Name;
                    if (fileName == fileNameSaida)
                    {
                        System.Console.WriteLine("Arquivo já existe.");
                        System.Console.ReadLine();
                    }
                }
                
                File.Copy(item, item.Replace(arquivos, saida).Replace(fileInfo.Name, fileName), true);
            }
        }
    }
}
