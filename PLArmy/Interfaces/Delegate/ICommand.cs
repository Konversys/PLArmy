namespace PLArmy.Interfaces.Delegate
{
    /// <summary>
    /// Командирские возможности
    /// </summary>
    interface ICommand
    {
        void GiveOrder();
        void ExecuteOrder();
    }
}
