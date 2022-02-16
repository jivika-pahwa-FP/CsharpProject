using System;

 class TicketBookingException : Exception {
    public TicketBookingException(string msg ) : base(msg){

    }
}
    class Passenger{
        string name;
        int age;
        
        public Passenger(string name,int age){
            this.name = name;
            this.age = age;
        }
        public void TicketBooking(int no_of_tickets){
            try{
            if(no_of_tickets > 2){
                throw new TicketBookingException("cannot book more than 2 tickets");
            }
            else{
                System.Console.WriteLine("Ticket Booked Successfully by \n Name : {0}  Age : {1} ",name,age);
            }
            }
            catch(Exception e){
                System.Console.WriteLine("Error : "+e.Message);
            }
        }
    }
    class Test{
        public static void main(string[] args)
        {
            Passenger obj = new Passenger("Jivika",23);
            System.Console.WriteLine("Enter number of tickets you want to book ");
            int noOfTickets = int.Parse(Console.ReadLine());
            obj.TicketBooking(noOfTickets);
        }
    }

