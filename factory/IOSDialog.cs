namespace Factory
{
    class IOSDialog : Dialog
    {
        public override IButton createButton()
        {
            return new IOSButton();
        }
    }
}