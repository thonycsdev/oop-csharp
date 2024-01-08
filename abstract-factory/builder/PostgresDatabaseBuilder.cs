using System.Data;
using System.Data.Common;
using Abstract;

namespace Builder
{
    class PostgresDatabaseBuilder : IDatabaseBuilder
    {

        private Database _Database { get; }

        public PostgresDatabaseBuilder()
        {
            _Database = new PostgresDatabase();
        }
        public void BuildCommand()
        {
            _Database.Command = new SqlCommand();
            _Database.Command.Connection = _Database.Connection;
        }

        public void BuildConnection()
        {
            _Database.Connection = new SqlConnection();
        }

        public void SetSettings()
        {
            throw new NotImplementedException();
        }

        public Database Database { get { return _Database; } }
    }

    internal class SqlCommand : DbCommand
    {
        public override string CommandText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int CommandTimeout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override CommandType CommandType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool DesignTimeVisible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override UpdateRowSource UpdatedRowSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected override DbConnection? DbConnection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override DbParameterCollection DbParameterCollection => throw new NotImplementedException();

        protected override DbTransaction? DbTransaction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        public override int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        public override object? ExecuteScalar()
        {
            throw new NotImplementedException();
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }

        protected override DbParameter CreateDbParameter()
        {
            throw new NotImplementedException();
        }

        protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
        {
            throw new NotImplementedException();
        }
    }
}