using first;

namespace OOPS_in_C_
{
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

       
            prv.GetVal();
        }
    }
}
