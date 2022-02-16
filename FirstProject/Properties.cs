using System;

namespace FirstProject{

    class Properties{

        int Regno,FeesCharged;
        string Name;

        public int registerNo{
            set{
                Regno = value;
            }
            get{
                return Regno;
            }
        }

        public int Fees{
            set{
                FeesCharged = value;
            }
            get{
                return FeesCharged;
            }
        }

        public string name{
            set{
                Name = value;
            }
            get{
                return Name;
            }
        }

    }
}