﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnumerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var repo = new StudentRepository();

            RegisterStudents(repo);

            var greetings = repo.SayGoodMorning();

            foreach (var greeting in greetings)
            {
                Console.WriteLine(greeting);
            }
            Console.ReadLine();
        }

        public static void RegisterStudents(StudentRepository repo)
        {
            repo.Add(new Teacher("Fredrik"));
            repo.Add(new CharbelStudent());


            repo.Add(new MimmiStudent());


            repo.Add(new MaqStudent());


            repo.Add(new MikaelStudent());

            repo.Add(new AdrianStudent());
            repo.Add(new TomasStudent());

            repo.Add(new JonasStudent());
            repo.Add(new ThomasStudent());


          
          
          
          
              repo.Add(new HelenaStudent());
          





            repo.Add(new UserStudent());

            repo.Add(new JensStudent());

            repo.Add(new SamuelbStudent());
        }
    }
}
