// using System;

// namespace practice{

//     public class passenger{
//         private string name;
//         private int age;
//         public passenger(string name,int age){
//             this.name = name;
//             this.age = age;
//         }

//         public void TicketBooking(int noOfTickets){
//                 try{
//                     if(noOfTickets > 2){
//                         throw new TicketBookingException("Can't book more than 2 tickets");
//                     }
//                     else{
//                         System.Console.WriteLine("{0} tickets booked successfully",noOfTickets);
//                     }
//                 }
//                 catch(TicketBookingException e){
//                     System.Console.WriteLine(e.Message);
//                 }
//         }
//     }
//         public class ExceptionHandling{
//             public static void Main(string[] args)
//             {
//                 passenger obj = new passenger("Jivika",23);
//                 obj.TicketBooking(2);
//             }
//         }
//     }
