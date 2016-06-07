using HelloWorld.Interfaces;
using HelloWorld.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Exception> exceptions = new List<Exception>();
            Logger logger = new Logger();

            try
            {
                new Message(new StringMessageCollector() as IMessageCollector, new LogWriter(logger as ILogger, new Writer() as IWriter) as IWriter).Expose();
            }
            catch (ArgumentNullException ArgumentNullException)
            {
                exceptions.Add(ArgumentNullException);
                
            }
            catch (NotImplementedException NotImplementedException)
            {
                exceptions.Add(NotImplementedException);
            }
            catch(Exception Exception)
            {
                exceptions.Add(Exception);
            }
            finally
            {
                logger.Log(exceptions);
            }

            Console.ReadKey();
        }
    }
}