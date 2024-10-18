//using System;

//namespace LearnChash.Augnet_c8
//{
//    class ExceptionDemo
//    {
//        class CustomeException : Exception
//        {
//            public CustomeException(string message, Exception innerException) : base(message, innerException) { }

//            public override string Message
//            {
//                get
//                {
//                    return "Divisor cannot be zero: " + base.Message;
//                }
//            }

//            public override string HelpLink
//            {
//                get
//                {
//                    return "Get more help: https://www.google.com";
//                }
//            }
//        }

//        static void Main(string[] args)
//        {
//            int num1, num2, num3;
//            try
//            {
//                Console.WriteLine("Enter 3 numbers");
//                num1 = int.Parse(Console.ReadLine());
//                num2 = int.Parse(Console.ReadLine());

//                //if (num2 == 0)
//                //{
//                //    // Custom exception with inner exception
//                //    throw new CustomeException("Cant be zero!!", new ArgumentException("Divisor was zero."));
//                //}

//                num3 = num1 / num2;
//                Console.WriteLine(num3);
//            }
//            catch (CustomeException ex)
//            {
//                Console.WriteLine(ex.Message);
//                Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
//            }
//            catch (FormatException ex)
//            {
//                Console.WriteLine("Input was not in the correct format: " + ex.Message);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//            finally
//            {
//                Console.WriteLine("Finally Done");
//            }

//            Console.WriteLine("Done now");
//        }
//    }
//}
