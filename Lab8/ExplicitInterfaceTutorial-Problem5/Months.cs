using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceTutorial_Problem5
{
    public class Months
    {
        public class January
        {
            public override string ToString()
            {
                return "January";
            }
        }

        private class February
        {
            public override string ToString()
            {
                return "February";
            }
        }

        private class March
        {
            public override string ToString()
            {
                return "March";
            }
        }

        private class April
        {
            public override string ToString()
            {
                return "April";
            }
        }

        private class May
        {
            public override string ToString()
            {
                return "May";
            }
        }

        private class June
        {
            public override string ToString()
            {
                return "June";
            }
        }

        private class July
        {
            public override string ToString()
            {
                return "July";
            }
        }

        private class August
        {
            public override string ToString()
            {
                return "August";
            }
        }

        private class September
        {
            public override string ToString()
            {
                return "September";
            }
        }

        private class October
        {
            public override string ToString()
            {
                return "October";
            }
        }

        private class November
        {
            public override string ToString()
            {
                return "November";
            }
        }

        private class December
        {
            public override string ToString()
            {
                return "December";
            }
        }

        public string this[string indexer]
        {
            get
            {
                switch (indexer)
                {
                    case "January": 
                        January jan= new January();
                        return jan.ToString();
                    case "February":
                        February f = new February();
                        return f.ToString();
                    case "March":
                        March m = new March();
                        return m.ToString();
                    case "April":
                        April a = new April();
                        return a.ToString();
                    case "May":
                        May may = new May();
                        return may.ToString();
                    case "June":
                        June j = new June();
                        return j.ToString();
                    case "July":
                        July july = new July();
                        return july.ToString();
                    case "August":
                        August august = new August();
                        return august.ToString();
                    case "September":
                        September s = new September();
                        return s.ToString();
                    case "October":
                        October o = new October();
                        return o.ToString();
                    case "November":
                        November n = new November();
                        return n.ToString();
                    case "December":
                        December d = new December();
                        return d.ToString();
                    default: throw new Exception("No such index");
                }
            }
        }

        public string this[int indexer]
        {
            get
            {
                switch (indexer)
                {
                    case 0:
                        January jan = new January();
                        return jan.ToString();
                    case 1:
                        February f = new February();
                        return f.ToString();
                    case 2:
                        March m = new March();
                        return m.ToString();
                    case 3:
                        April a = new April();
                        return a.ToString();
                    case 4:
                        May may = new May();
                        return may.ToString();
                    case 5:
                        June j = new June();
                        return j.ToString();
                    case 6:
                        July july = new July();
                        return july.ToString();
                    case 7:
                        August august = new August();
                        return august.ToString();
                    case 8:
                        September s = new September();
                        return s.ToString();
                    case 9:
                        October o = new October();
                        return o.ToString();
                    case 10:
                        November n = new November();
                        return n.ToString();
                    case 11:
                        December d = new December();
                        return d.ToString();
                    default: throw new Exception("No such index");
                }
            }
        }

        public string January
        {
            get
            {
                Console.WriteLine("January");
            }
        }
    }
}
