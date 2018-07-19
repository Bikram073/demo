using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindscape.Raygun4Net;
using Mindscape.Raygun4Net.Messages;
using SharpRaven;
using SharpRaven.Data;

namespace DemoRaygun
{
    class Program
    {
        private static RaygunClient _raygunClient = new RaygunClient("NsdlafqONYML+ncpf5lj7Q==");
       
     

        static void Main(string[] args)
        {
            var ravenClient = new RavenClient("https://4ed3f625fda04e2fb7dbdbada23e42b4@sentry.io/1242820");
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
           
                Add add = new Add();
                Console.WriteLine("Enter two numbers:");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int sum = add.Sum(num1, num2);
                int divide = add.Divide(num1, num2);
                Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
                Console.WriteLine($"The divide of {num1} and {num2} is {divide}");
                Console.ReadLine();
           
          
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {

            
            _raygunClient.Send(e.ExceptionObject as Exception );
        
        }

    }
    public class message : IRaygunMessageBuilder
    {
        message obj = new message();

        

        public RaygunMessage Build()
        {
            throw new NotImplementedException();
        }

        public IRaygunMessageBuilder SetClientDetails()
        {
            throw new NotImplementedException();
        }

        public IRaygunMessageBuilder SetEnvironmentDetails()
        {
            throw new NotImplementedException();
        }

        public IRaygunMessageBuilder SetExceptionDetails(Exception exception)
        {
            throw new NotImplementedException();
        }

        public IRaygunMessageBuilder SetMachineName(string machineName)
        {
            throw new NotImplementedException();
        }

        public IRaygunMessageBuilder SetTags(IList<string> tags)
        {
            throw new NotImplementedException();
        }

        public IRaygunMessageBuilder SetTimeStamp(DateTime? currentTime)
        {
            throw new NotImplementedException();
        }

        public IRaygunMessageBuilder SetUser(RaygunIdentifierMessage user)
        {
            throw new NotImplementedException();
        }

        public IRaygunMessageBuilder SetUserCustomData(IDictionary userCustomData)
        {
            throw new NotImplementedException();
        }

        public IRaygunMessageBuilder SetVersion(string version)
        {
            throw new NotImplementedException();
        }
    }
}
