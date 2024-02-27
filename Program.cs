using System;

namespace WordToPDF
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Word2PDF word2PDF = new Word2PDF();
            word2PDF.ShowDialog();
        }
    }
}