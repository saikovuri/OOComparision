using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiple_Interfaces
{
    interface IStorable
    {
        void Read( );
        void Write(object obj);
        int Status { get; set; }
    }

    // here's the new interface
    interface ICompressible
    {
        void Compress( );
        void Decompress( );
    }

    public class Document : IStorable, ICompressible
    {
        public Document(string s)
        {
            Console.WriteLine("Creating document with: {0}", s);
        }

        #region IStorable

        public void Read( )
        {
            Console.WriteLine("Executing Document's Read Method
                               for IStorable");
        }

        public void Write(object o)
        {
            Console.WriteLine("Executing Document's Write Method
                               for IStorable");
        }

        public int Status{ get; set;}

        #endregion     // IStorable

        #region ICompressible

        public void Compress( )
        {
            Console.WriteLine("Executing Document's Compress Method
                               for ICompressible");
        }
        public void Decompress( )
        {
            Console.WriteLine("Executing Document's Decompress Method
                               for ICompressible");
        }
        #endregion  // ICompressible

    }

    class Tester
    {
        public void Run( )
        {
            Document doc = new Document("Test Document");
            doc.Status = -1;
            doc.Read( );          // invoke method from IStorable
            doc.Compress( );      // invoke method from ICompressible
            Console.WriteLine("Document Status: {0}", doc.Status);
        }

        static void Main( )
        {
            Tester t = new Tester( );
            t.Run( );
        }
    }
}

// The output looks like below:
//
//
// Creating document with: Test Document
// Executing Document's Read Method for IStorable
// Executing Document's Compress Method for ICompressible
// Document Status: -1
