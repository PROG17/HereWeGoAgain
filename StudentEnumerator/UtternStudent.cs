using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnumerator
{
    public class UtternStudent : Person
    {
        public override string SayGoodmorning()
        {
            return @"Uttern är ett smidigt, 
långsmalt djur med korta ben, brett huvud och lång, muskulös svans. 
Pälsen är ljusbrun med en nästan vit haklapp. Den är starkt anpassad för ett liv i vatten";
        }
    }
}
