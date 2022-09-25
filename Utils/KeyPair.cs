using ProjetoBio.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum = ProjetoBio.Animais.Enum;

namespace ProjetoBio.Utils
{
    public class KeyPair<T> where T : Enum
    {
        public string Key { get; }
        public T Value { get; }

        public KeyPair(T e) : this(e.Text, e) { }

        public KeyPair(string key, T value)
        {
            Key = key;
            Value = value;
        }
    }

    public static class KeyPair
    {
        public const string DefaultEmptyText = "hi!";

        public static KeyPair<T> EmptyKeyPair<T>(string emptyText = DefaultEmptyText) where T : Enum => new KeyPair<T>(emptyText, null);

        public static KeyPair<T>[] ToKeyPairs<T>(T[] Values) where T : Enum
            => Values.Select(e => new KeyPair<T>(e)).ToArray();

        public static KeyPair<T>[] GetKeyPairs<T>() where T : Enum => ToKeyPairs(Enum.GetValues<T>());

        public static KeyPair<T>[] GetKeyPairs<T>(string emptyMessage) where T : Enum 
        {
            var keypairs = new List<KeyPair<T>> { EmptyKeyPair<T>(emptyMessage) };
            keypairs.AddRange(GetKeyPairs<T>());
            return keypairs.ToArray();
        }

        public static KeyPair<T>[] GetKeyPairsAndEmpty<T>(string emptyText = DefaultEmptyText) where T : Enum => GetKeyPairs<T>(emptyText);
    }
}
