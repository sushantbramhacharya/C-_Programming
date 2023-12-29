using first;

namespace OOPS_in_C_
{
    //Properties and getter setter method overloading using this

    //Example Code Non-Runnable
    /*
     class Person
        {
          private string name; // field
          public string Name    // property
            {
              get { return name; }
              set { 
              if(value.ToLower().Trim()=="liam")
              {
      	        name="Boss";
              }
            }  
        }

        class Program
        {
          static void Main(string[] args)
          {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
          }
        }

    Output======> Boss
     */
    class PropertiesExample
    {
        public string name { get; set; }
        public readonly int age;//Like final keyword once set cant be changed
        public string description
        {
            get
            {
                return description;
            }
            set
            {
                if (value == null)
                {
                    description = string.Empty;
                }
                else
                {
                    description += value;
                }
            }
        }

        //Overloads using this keyword
        public PropertiesExample() : this("No Name", 0, "No Description") { }
        public PropertiesExample(string name) : this(name, 0, "No Description") { }

        //Construtor
        public PropertiesExample(string name,int age, string description)
        {
            this.name = name;
            this.age = age;
            this.description = description; 
        }
    }

    //Private
    class PrivateProj
    {
        private int id;
        //By Default members are private
        string name;
        
        //needs public method to set and get values also known as encapsulation
        public void SetVal(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void GetVal()
        {
            Console.WriteLine("{0} id is for name {1}.",id,name);
        }
    }
    //By Default classes are internal
    class ProtectedProj
    {
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method Ran By ProtectedProj");
        }
    }
    internal class Classes:ProtectedProj
    {
        internal Classes() 
        {
            //Public
            //Accessing Public Class From Another Project File In Same Solution By adding Project Reference in this Project
            PublicProg publicProg = new PublicProg();

            //Internal
            //Accessing Internal Class form Same Project but different files or within same assembly
            InternalProj internalProj = new InternalProj();

            //Protected
            //Accessing Protected methods by extending using Inheritance
            ProtectedMethod();

            //Private Values
            //Accessing Private with getter and setter Methods
            PrivateProj prv = new PrivateProj();
            prv.SetVal(1, "Henry");
            //Test
       
            prv.GetVal();
        }
    }
}
