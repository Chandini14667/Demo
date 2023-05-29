namespace MockPractice
{
    public class FileService
    {
        private IFileReader _reader;
        public FileService(IFileReader reader)
        {
            _reader = reader;
        }

        public string ReadData()
        {
            return _reader.ReadText();
        }
    }
}