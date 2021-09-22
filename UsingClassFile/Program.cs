using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace UsingClassFile
{
    public class SpecialExeption : Exception
    {
    }

    public class MyClass { public int qwerty = 0; public void MC ( ) { if ( qwerty == 0 ) { throw new SpecialExeption ( ); } } }

    public class One
    {
        private class Two { public int aaa = 0; public void func ( ) { Console . Write ( "two" ); } }

        public void function ( )
        {
            var a = new Two ( );

            Console . Write ( a . GetType ( ) . FullName ); Console . ReadKey ( );
        }
    }



    public interface IX { void X ( int a ); int Y ( ); }

    public interface IY { void X ( int a ); int Z ( ); }

    public interface IZ : IY { void ZYX ( double a ); int ZY ( ); void X ( double a ); }

    public class XY : IX, IZ
    {
        public void X ( int a ) { Console . Write ( "one" ); }

        public void X ( double a ) { Console . Write ( "one" ); }

        public void ZYX ( double a ) { Console . Write ( "one" ); }

        public int ZY ( ) { Console . Write ( "one" ); return 0; }

        public int Y ( ) { Console . Write ( "one" ); return 0; }

        public int Z ( ) { Console . Write ( "one" ); return 0; }

    }



    abstract class abstr_class
    {
        public abstract void mbr_1 ( );

        public virtual void mbr_2 ( ) { int a = 3; int b = 5; int c = a + b; }
    }

    class my_class : abstr_class
    {
        public override void mbr_1 ( )
        {
            throw new NotImplementedException ( );
        }

        public override void mbr_2 ( )
        {
            int a = 3; int b = 5; int c = a + b + a;
        }
    }





    class Program
  {

    static void Main(string[] args)
    {
       var en = Encoding.UTF8; var count = 0; var str = "changes in master brench";   var str2 = "new change in master brench";

             using (var new_wrt = new BinaryWriter(File.Open("similar_real.dat", FileMode.OpenOrCreate), Encoding.UTF8))
              {
                  int a_0 = 4; int a_1 = 3; int a_2 = 3; int a_3 = 3; int a_4 = 3;
                  new_wrt.Write(a_0); new_wrt.Write(a_1); new_wrt.Write(a_2); new_wrt.Write(a_3); new_wrt.Write(a_4); 
              }
            //      var str = ""; var fs = new FileStream("similar_real.dat", FileMode.Open); fs.Position = 0; str = fs.Position.ToString(); byte bt = 109;
            //        fs.WriteByte(bt); str += fs.Position.ToString();  Console.Write(fs.Length.ToString()); Console.Write(str);
            //      Console.ReadKey();  fs.Close();

            /*  int x = 5; var arr = new byte[4] ; byte y; int k = 0; int xx = 0;
              for (var i = 0; i < 4; i++) { if (i == 0) { k = 1; } else { k = 128; }   x = (int)( x / k );  y = (byte)x;  arr[i] = y; }
              for (var i = 0; i < 4; i++) { Console.Write(arr[i].ToString()); }
              Console.Write("          ");
              for (var i = 0; i < 4; i++) { var q = 0; if (i != 0) q = 1; xx += (int)arr[i] * (int)Math.Pow(2, 8*i-q ); }
              Console.Write(xx.ToString());
              string str = "128";
              byte bb = Byte.Parse(str);          Console.Write(bb.ToString());
              Console.ReadKey();*/
            /*  using (var new_wrt = new BinaryReader(File.Open("similar_real.dat", FileMode.Open), Encoding.UTF8))
              {
                  byte a = 4;
                 //a = new_wrt.ReadInt32();
                  var arr = new List<char>();
                  for (var i = 0; i < 20; i++) { arr.Add(new_wrt.ReadChar()); }
                  for (var i = 0; i < arr.Count; i++) { Console.Write(arr[i].ToString()); } Console.ReadKey();
              }*/

            //  uint x = 770; int y = (int)(x / 255); char ch = 'm'; int xx = 0; char[] ch_arr = new char[] {'п'}; string str = "m"; int utf_Bytes = Encoding.Unicode.GetByteCount(str);
            //    byte b = (byte)y; byte[] sh = Encoding.ASCII.GetBytes(ch_arr); ushort yy = 32768; var t = (int)b;
            //Console.Write(x.GetType().ToString());
            // var a =  Encoding.ASCII.GetByteCount(ch_arr);

            //  var fs = new FileStream("test2.txt", FileMode.Append); var bw = new BinaryWriter(new FileStream("test2.txt", FileMode.Append), en);

            //var fs = File.Create("test_3.txt");
            //  File.WriteAllLines("test_3.txt", new string[] {"qw","yt","qw"});
            //  File.AppendAllLines ("test_3.txt", new string[] { "123", "456", "789" });
            // string[] s_a = File.ReadAllLines("test_3.txt");
            // for (var i = 0; i < s_a.Length; i++) { Console.Write(s_a[i]); }
            // Console.ReadKey();

            // var fs = new FileStream( "test_3.txt", FileMode.Append );

            // var c = Encoding.UTF8.GetByteCount("йцукен"); char[] chars = Encoding.UTF8.GetChars( Encoding.UTF8.GetBytes("йцукен") );

            //  string[] s_a = File.ReadAllLines("test_3.txt");

            /*var list = new List<int>(); list.Add(2); Console.Write(list.Count.ToString());
            for (var i = 0; i < list.Count; i++) { if (i < 10) { list.Add(2); } Console.Write(list.Count.ToString()); }
            var a = Int32.MaxValue;  var b = Int32.MaxValue;*/

            //---------------------------------------------------------------------------------------------------------------------------------


            /*      var list = new List<int>(); string str = "";
                  list.Add(3); list.Add(3); list.Add(3); list.Add(3); list.Add(3);

                  var mc = new MyClass();

                  //try { mc.MC(); } catch ( SpecialExeption e ) { Console.Write( e.Message + "&&  " ); }

                  try { list[6] = 9; }
                  catch ( ArgumentOutOfRangeException e )
                  {
                      str = e.Source + "  /  " + e.StackTrace + "  /  " + e.HelpLink + "  /  " + e.HResult.ToString() + "  /  "
                            + e.ParamName + "  /  " + list.GetHashCode().ToString() + "  &  "; }
                  Console.Write(str);     Console.Write(str);

                  Type tp = mc.GetType();

                  foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
                  {
                      Console.Write(t.FullName + "  /  ");
                  }

                  MarshalByRefObject marsh_obj = null;

                  Assembly asm = Assembly.LoadFrom("MyApp.dll");

                 // Type t = asm.GetType("MyApp.Program", true, true);

                  // создаем экземпляр класса Program
                  object obj = Activator.CreateInstance(t);
                  MethodInfo method = t.GetMethod("GetResult");
                  object result = method.Invoke(obj, new object[] { 6, 100, 3 });

                  //for (var i = 0; i < chars.Length; i++) { Console.Write(chars[i]); }


                  // 1. Создать канал между клиентом и сервером, создать объект типа HttpChannel
                  HttpChannel ch = new HttpChannel(5000); // номер порта = 5000 - выбран наугад

                  // 2. Зарегистрировать канал ch, в методе RegisterChannel() указывается уровень безопасности false
                  ChannelServices.RegisterChannel(ch, false);

                  // 3. Зарегистрировать сервис как WKO
                  RemotingConfiguration.RegisterWellKnownServiceType(
                      typeof(ClassLibrary1.Class1),
                      "MathFunctions.soap",
                      WellKnownObjectMode.Singleton);




                  Console.ReadKey(); */


            var aa = new One ( );   aa . function ( );





        }
   }
}







