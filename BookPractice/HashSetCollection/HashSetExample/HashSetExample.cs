using System;
using System.Collections.Generic;
using System.Linq;

public class HashSetExample
{
    static void Main()
    {
        // HashSet<T> — это коллекция, которая хранит ТОЛЬКО УНИКАЛЬНЫЕ элементы.
        // Дубликаты автоматически отбрасываются.
        // Порядок элементов НЕ гарантирован (внутри всё перемешано).
        // Главная фишка: метод Contains() работает МГНОВЕННО (O(1)).

        // ============================================
        // 1. СОЗДАНИЕ
        // ============================================
        HashSet<int> numbers = new HashSet<int>();

        // Создание из существующей коллекции (мгновенно убирает дубликаты)
        List<int> listWithDuplicates = new List<int> { 1, 2, 2, 3, 3, 3, 4 };
        HashSet<int> uniqueFromList = new HashSet<int>(listWithDuplicates);

        // Инициализатор коллекции
        HashSet<string> fruits = new HashSet<string> { "Яблоко", "Банан", "Апельсин" };

        // ============================================
        // 2. ДОБАВЛЕНИЕ (Add) — возвращает bool!
        // ============================================
        // Add возвращает true, если элемент ДОБАВИЛСЯ,
        // и false, если такой элемент УЖЕ ЕСТЬ (не добавился).
        bool added1 = numbers.Add(10);  // true — добавилось
        bool added2 = numbers.Add(20);  // true
        bool added3 = numbers.Add(10);  // false — дубликат, не добавилось

        Console.WriteLine($"Добавление 10 в первый раз: {added1}"); // True
        Console.WriteLine($"Добавление 10 во второй раз: {added3}"); // False

        // ============================================
        // 3. ПРОВЕРКА НАЛИЧИЯ (Contains) — работает мгновенно
        // ============================================
        // В List<int> этот метод перебирает все элементы по очереди.
        // В HashSet он находит элемент за 1 шаг.
        Console.WriteLine($"\nЕсть ли 20 в множестве? {numbers.Contains(20)}"); // True
        Console.WriteLine($"Есть ли 99 в множестве? {numbers.Contains(99)}"); // False

        // ============================================
        // 4. РАЗМЕР И ОЧИСТКА
        // ============================================
        Console.WriteLine($"Количество элементов: {numbers.Count}"); // 2 (10 и 20)
                                                                     // numbers.Clear(); // Полная очистка — раскомментируй, если нужно

        // ============================================
        // 5. УДАЛЕНИЕ (Remove)
        // ============================================
        numbers.Remove(10);
        Console.WriteLine($"После удаления 10, Count = {numbers.Count}"); // 1

        // ============================================
        // 6. ПЕРЕБОР (порядок НЕ гарантирован!)
        // ============================================
        Console.WriteLine("\nПеребор множества fruits:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
            // Порядок может быть НЕ таким, как ты добавлял!
        }

        // ============================================
        // 7. ОПЕРАЦИИ НАД МНОЖЕСТВАМИ
        // ============================================
        HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7 };

        // --- ОБЪЕДИНЕНИЕ (UnionWith) ---
        // Добавляет все элементы из другого множества
        HashSet<int> union = new HashSet<int>(setA); // копия setA
        union.UnionWith(setB);
        Console.WriteLine("\nОбъединение A и B: " + string.Join(", ", union));
        // Результат: 1, 2, 3, 4, 5, 6, 7

        // --- ПЕРЕСЕЧЕНИЕ (IntersectWith) ---
        // Оставляет только то, что есть в ОБОИХ множествах
        HashSet<int> intersection = new HashSet<int>(setA);
        intersection.IntersectWith(setB);
        Console.WriteLine("Пересечение A и B: " + string.Join(", ", intersection));
        // Результат: 4, 5

        // --- РАЗНОСТЬ (ExceptWith) ---
        // Удаляет из текущего то, что есть в другом
        HashSet<int> difference = new HashSet<int>(setA);
        difference.ExceptWith(setB);
        Console.WriteLine("Разность A и B (что есть в A, но нет в B): " + string.Join(", ", difference));
        // Результат: 1, 2, 3

        // --- СИММЕТРИЧНАЯ РАЗНОСТЬ (SymmetricExceptWith) ---
        // Оставляет то, что НЕ совпало (исключает общие элементы)
        HashSet<int> symDiff = new HashSet<int>(setA);
        symDiff.SymmetricExceptWith(setB);
        Console.WriteLine("Симметричная разность A и B: " + string.Join(", ", symDiff));
        // Результат: 1, 2, 3, 6, 7 (убрали 4 и 5 как общие)

        // ============================================
        // 8. ПРОВЕРКИ МНОЖЕСТВ
        // ============================================
        HashSet<int> small = new HashSet<int> { 2, 3 };
        HashSet<int> big = new HashSet<int> { 1, 2, 3, 4, 5 };

        // --- ПОДМНОЖЕСТВО (IsSubsetOf) ---
        // true, если ВСЕ элементы small есть в big
        Console.WriteLine($"\n{{2, 3}} — подмножество {{1..5}}? {small.IsSubsetOf(big)}"); // True

        // --- НАДМНОЖЕСТВО (IsSupersetOf) ---
        // true, если big содержит ВСЕ элементы small
        Console.WriteLine($"{{1..5}} — надмножество {{2, 3}}? {big.IsSupersetOf(small)}"); // True

        // --- ЕСТЬ ЛИ ОБЩИЕ ЭЛЕМЕНТЫ (Overlaps) ---
        HashSet<int> other = new HashSet<int> { 5, 6, 7 };
        Console.WriteLine($"Есть ли общие элементы между {{1..5}} и {{5,6,7}}? {big.Overlaps(other)}"); // True

        // --- ПОЛНОЕ РАВЕНСТВО (SetEquals) ---
        HashSet<int> copy = new HashSet<int> { 3, 2, 1, 5, 4 }; // другой порядок
        Console.WriteLine($"{{1..5}} == {{3,2,1,5,4}}? {big.SetEquals(copy)}"); // True (порядок не важен)

        // ============================================
        // 9. ПРАКТИЧЕСКИЙ ПРИМЕР: УБРАТЬ ДУБЛИКАТЫ ИЗ СПИСКА
        // ============================================
        List<string> namesWithDupes = new List<string> { "Иван", "Мария", "Иван", "Петр", "Мария" };
        HashSet<string> uniqueNames = new HashSet<string>(namesWithDupes);

        Console.WriteLine("\nУникальные имена:");
        foreach (string name in uniqueNames)
        {
            Console.WriteLine(name);
        }

        // ============================================
        // 10. ПРАКТИЧЕСКИЙ ПРИМЕР: ПОИСК ПЕРВОГО ДУБЛИКАТА
        // ============================================
        List<int> stream = new List<int> { 5, 3, 8, 3, 9, 5 };
        HashSet<int> seen = new HashSet<int>();

        Console.WriteLine("\nИщем первый дубликат в потоке:");
        foreach (int n in stream)
        {
            if (!seen.Add(n)) // если Add вернул false — значит, уже было
            {
                Console.WriteLine($"Первый дубликат: {n}");
                break;
            }
        }

        // ============================================
        // 11. ПРАКТИЧЕСКИЙ ПРИМЕР: СИСТЕМА ДРУЗЕЙ
        // ============================================
        // Dictionary, где ключ — имя игрока, значение — множество его друзей.
        // HashSet идеален, потому что друзья не должны повторяться.
        Dictionary<string, HashSet<string>> friends = new Dictionary<string, HashSet<string>>
            {
                { "Алекс", new HashSet<string> { "Борис", "Вика", "Гена" } },
                { "Борис", new HashSet<string> { "Алекс", "Вика" } },
                { "Вика", new HashSet<string> { "Алекс", "Борис" } }
            };

        // Проверка взаимной дружбы
        bool mutual = friends["Алекс"].Contains("Борис") && friends["Борис"].Contains("Алекс");
        Console.WriteLine($"\nАлекс и Борис — взаимные друзья? {mutual}"); // True

        // Общие друзья Алекса и Бориса
        HashSet<string> commonFriends = new HashSet<string>(friends["Алекс"]);
        commonFriends.IntersectWith(friends["Борис"]);
        Console.WriteLine("Общие друзья Алекса и Бориса: " + string.Join(", ", commonFriends));
        // Результат: Вика

        // ============================================
        // ИТОГ: КОГДА ИСПОЛЬЗОВАТЬ HASHSET?
        // ============================================
        // 1. Когда нужны ТОЛЬКО УНИКАЛЬНЫЕ элементы.
        // 2. Когда нужна МГНОВЕННАЯ проверка Contains (быстрее, чем List).
        // 3. Для операций над множествами: объединение, пересечение, разность.
        // 4. Для быстрого удаления дубликатов из List.
        // 5. В играх: список убитых врагов, посещённых клеток, уникальных предметов.

        // ВАЖНО: HashSet НЕ поддерживает доступ по индексу (нельзя сделать hs[0]).
        // Если нужен доступ по индексу — используй List.

    }
}