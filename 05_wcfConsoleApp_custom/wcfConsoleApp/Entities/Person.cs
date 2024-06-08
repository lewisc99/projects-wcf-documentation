using System.Runtime.Serialization;
using System;

namespace wcfConsoleApp
{

    [DataContract]
    public class Person
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public int Age { get; set; }

        // Method to handle the OnSerializing event
        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            Console.WriteLine("Before Serialization");
        }

        // Method to handle the OnSerialized event
        [OnSerialized]
        private void OnSerialized(StreamingContext context)
        {
            Console.WriteLine("After Serialization");
        }

        // Method to handle the OnDeserializing event
        [OnDeserializing]
        private void OnDeserializing(StreamingContext context)
        {
            Console.WriteLine("Before Deserialization");
        }

        // Method to handle the OnDeserialized event
        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Console.WriteLine("After Deserialization");
        }
    }
}
