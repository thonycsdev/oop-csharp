using Factory;

namespace Builder
{
    class Pizza : Pasta
    {
        public override void SetTimeInTheOven()
        {
            this._timeInTheOven = 30;
        }
    }
}