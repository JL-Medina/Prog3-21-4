

namespace Prog3_21_4
{
    public class Program
    {
        public static void Main()
        {
            List<Persona> personas = new();

            for(var i = 0; i < 3; i++) 
            { 
                Console.WriteLine($"Ingrese el nombre {i+1}: ");
                personas.Add(new Persona(Console.ReadLine()));
            }
            foreach(var persona in personas)
            {
                Console.WriteLine(persona.ToString());
            }
            
        }
    }
}