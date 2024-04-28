using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    public class ActionWithArray<T>
    {
        private T[] _array;
        private List<T> _result;
        private List<T> _batch;

        public string FilePath { get; private set; }
        public int LengthArray => _array?.Length ?? 0;

        public int CountBetween10And100 => CountElements();

        public T[] Array
        {
            get
            {
                if (_array == null || _array.Length < 1)
                    throw new ArgumentException("Массив пустой");

                return _array;
            }
        }

        private int CountElements()
        {
            if (_array == null || _array.Length < 1)
                return 0;

            // Возвращает число, которое соответсвует требованиям число > 9 и < 101 (между 10 и 100)
            return _array.Count(item => Convert.ToInt32(item) > 9 && Convert.ToInt32(item) < 101);
        }

        public async Task FillFromFileCSVAsync(string filePath, int batchSize)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be empty.");

            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found.", filePath);

            FilePath = filePath;
            
            if (_result == null)
                _result = new List<T>();
            else
                _result.Clear();

            if (_batch == null)
                _batch = new List<T>();
            else
                _batch.Clear();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                int lineNumber = 0;

                while ((line = await reader.ReadLineAsync()) != null)
                {
                    lineNumber++;

                    try
                    {
                        T number = (T)Convert.ChangeType(line, typeof(T));
                        _batch.Add(number);

                        if (_batch.Count >= batchSize)
                        {
                            _result.AddRange(_batch);
                            _batch.Clear();
                        }
                    }
                    catch (FormatException)
                    {
                        throw new FormatException($"Неизвестный формат в строке {lineNumber}.");
                    }
                }

                _result.AddRange(_batch);
            }

            _array = _result.ToArray();
        }

        public async Task FilledArrayNumbersFibAsync(int length)
        {
            if (length < 1)
                throw new ArgumentException("Длина не может быть меньше 1");

            _array = new T[length];

            await Task.Run(() =>
            {
                dynamic a = (dynamic)Convert.ChangeType(0, typeof(T));
                dynamic b = (dynamic)Convert.ChangeType(1, typeof(T));
                _array[0] = a;
                _array[1] = b;

                for (int i = 2; i < length; i++)
                {
                    dynamic temp = a;
                    a = b;
                    b = temp + b;
                    _array[i] = b;
                }
            });
        }
    }
}
