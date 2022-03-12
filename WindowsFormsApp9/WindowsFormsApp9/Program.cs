using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public class Program : StringLogInterface
    {

        protected Program log; // reference to first node of linked 
        protected Program currNode;                     // list that holds the StringLog strings
        protected String name;      // name of this StringLog
        protected Program link;
        protected string info;
        protected bool parents = false;
        protected Program soulmate;
        protected string[] child;
        protected string sibling;
        protected bool Male;
        protected string date_birth;
        protected string date_death;
        protected bool first = false;
        public void children(string element,bool Male,string date_birth,string date_death = null)
        {
            if(this.parents == true)
            {
                Program newNode = new Program(element,Male,date_birth,date_death);
                newNode.setLink1(log);
                log = newNode;
                log.first = true;
            }
        }
        public void sibling(string element, bool Male, string date_birth, string date_death = null)
        {
                Program newNode = new Program(element, Male, date_birth, date_death);
                newNode.setLinkS(log);
                log = newNode;
                first = false;
        }
        public string getName()
        {
            return this.name;
        }
        public void setInfo(String info)
        {
            this.info = info;
        }
        void GetLLStringNode()
        {
            Program currNode = log;
            while (currNode != null)
            {
                Console.WriteLine(currNode.getInfo());
                currNode = currNode.getLink();
            }
        }
        Program(string name)
        {
            this.name = name;
            link = null;
            child = null;
            soulmate = null;

        }
        Program(String name, bool Male,string date_birth,string date_death = null)
        {
            this.Male = Male;
            this.date_death = date_death;
            this.date_birth = date_birth;
            this.name = name;
            link = null;
            child = null;
            soulmate = null;
        }
        public Program getLink()
        {
            return link;
        }
        public String getInfo()
        {
            return info;
        }
        public void setLink(Program link)
        {
            this.link = link;
        }
        public void insert(String element)
        {
            Program newNode = new Program(element);
            newNode.setLink(log);
            log = newNode;
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Program log = new Program("salim",true,"1935/8/24");
            log.GetMarried1("faeda",false,"1935");
            log.children("Raed",true,"1975");



        }
    }
interface StringLogInterface
    {
        void insert(String element);
        // Precondition:   This StringLog is not full.
        // 
        // Places element into this StringLog.
    }

}
