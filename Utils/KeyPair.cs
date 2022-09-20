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

        public KeyPair(T e)
        {
            Key = e.Text;
            Value = e;  // e
        }

        public static KeyPair<T>[] GetKeyPairs() => KeyPair.GetKeyPairs<T>();
    }

    public static class KeyPair
    {
        public static KeyPair<T>[] ToKeyPairs<T>(T[] Values) where T : Enum
            => Values.Select(e => new KeyPair<T>(e)).ToArray();

        public static KeyPair<T>[] GetKeyPairs<T>() where T : Enum
            => ToKeyPairs<T>(Enum.GetValues<T>());
    }
}
