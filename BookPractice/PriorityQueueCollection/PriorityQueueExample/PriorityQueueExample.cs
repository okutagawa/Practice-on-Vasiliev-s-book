using System;
using System.Collections.Generic;

public class PriorityQueueExample
{
    static void Main()
    {
        // PriorityQueue<TElement, TPriority>
        // TElement = string (имя пациента)
        // TPriority = int (срочность: чем МЕНЬШЕ число, тем РАНЬШЕ выйдет)
        PriorityQueue<string, int> hospital = new PriorityQueue<string, int>();

        // Добавляем пациентов через Enqueue
        // Формат: hospital.Enqueue(element, priority);
        hospital.Enqueue("Гриша", 3);  // выйдет третьим
        hospital.Enqueue("Петя", 1);   // выйдет ПЕРВЫМ (самый срочный)
        hospital.Enqueue("Маша", 2);   // выйдет вторым
        hospital.Enqueue("Никита", 4); // выйдет последним

        // Peek() — подсмотреть, кто сейчас первый, НЕ удаляя его
        Console.WriteLine($"Следующий на приём: {hospital.Peek()}");
        Console.WriteLine($"Всего в очереди: {hospital.Count} пациентов\n");

        // === СПОСОБ 1: Снять ОДИН элемент без приоритета ===
        // Dequeue() возвращает только элемент, приоритет теряется
        string firstPatient = hospital.Dequeue();
        Console.WriteLine($"[Способ 1] Первым вышел: {firstPatient}\n");

        // === СПОСОБ 2: TryDequeue с циклом (РЕКОМЕНДУЕМЫЙ) ===
        // Пока очередь не пуста — снимаем пациента и его приоритет
        Console.WriteLine("[Способ 2] Разбираем оставшихся через TryDequeue:");
        while (hospital.TryDequeue(out string patientName, out int patientPriority))
        {
            Console.WriteLine($"  Пациент: {patientName}, приоритет: {patientPriority}");
        }

        // Проверяем, что очередь действительно пуста
        Console.WriteLine($"\nОчередь пуста? Count = {hospital.Count}");

        // === СПОСОБ 3: Dequeue с out-параметрами (если работает в твоём проекте) ===
        // Если у тебя Dequeue(out, out) не компилируется — оставь закомментированным.
        // hospital.Dequeue(out string elem, out int prio);

        Console.WriteLine("\nПрограмма завершена. Нажмите любую клавишу...");
        Console.ReadKey();
    }
}