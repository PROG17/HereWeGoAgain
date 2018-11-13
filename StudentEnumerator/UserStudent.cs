using System;

namespace StudentEnumerator
{
    public class UserStudent : Person
    {
        public override string SayGoodmorning()
        {
            return $"Hejsan säger {Environment.UserName}!";
        }
    }
}