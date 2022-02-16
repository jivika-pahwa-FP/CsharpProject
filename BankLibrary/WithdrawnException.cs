using System;

namespace BankLibrary{
public class WithdrawnException : Exception{
        public WithdrawnException(string message) : base(message){

        }
}

}
