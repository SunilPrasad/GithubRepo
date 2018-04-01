namespace AccountService
{
    public interface IRepository
    {
        bool CheckUser(string userName);
        bool ValidateUser(string userName, string password);
    }

    public class StatusResult
    {
        private bool _status;
        public StatusResult(bool status)
        {
            _status = status;

        }

        public bool Status
        {
            get { return _status; }
        }
    }
}