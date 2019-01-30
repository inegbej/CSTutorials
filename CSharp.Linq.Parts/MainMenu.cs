using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Linq.Parts
{
    public abstract class MainMenu
    {
        public virtual void SetMenu()
        {
            char myChoice;

            do
            {
                myChoice = GetMenu();
                MakeDecision(myChoice);
            } while (myChoice != 'Q' && myChoice != 'q');
        }

        public abstract char GetMenu();

        public abstract void MakeDecision(char myChoice);

    }
}
