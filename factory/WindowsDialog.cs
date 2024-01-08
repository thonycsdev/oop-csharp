namespace Factory
{
    class WindowsDialog : Dialog
    {
        public override IButton createButton()
        {
            return new WindowsButton();
        }
    }
}