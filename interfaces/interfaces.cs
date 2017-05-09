using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementing_Interface
{
   interface IStorable
   {
       void Read( );
       void Write( object obj );
       int Status { get; set; }
   }

   public class Document : IStorable
   {

       public Document( string s )
      {
         Console.WriteLine( "Creating document with: {0}", s );
      }

#region IStorable

      public void Read( )
      {
         Console.WriteLine( "Executing Document's Read
                             Method for IStorable" );
      }

      public void Write( object o )
      {
         Console.WriteLine( "Executing Document's Write
                             Method for IStorable" );
      }

      // property required by IStorable
      public int Status { get; set;}

#endregion

   }

   class Tester
   {
      public void Run( )
      {
         Document doc = new Document( "Test Document" );
         doc.Status = -1;
         doc.Read( );
         Console.WriteLine( "Document Status: {0}", doc.Status );
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
// Document Status: -1
