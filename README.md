Цей міні додаток https://portaonetesttask.azurewebsites.net/
є моєю імплементацією вступного тестового завдання на стажування в PortaOne в березні 2024.

Завдання передбачало створення додатка, яким може скористатися люба людина на основних розповсюджених операційних системах.
Суть додатку в тому, що надавши необхідний файл txt, де кожен рядок містить певні цифри отримаєш певні результати обчислень.
Саме завдання(оригінальний текст) нижче.

Умова задачі
У нас є файл, з  великим набором цілих чисел (файл можна скачати за посиланням: [https://drive.google.com/file/d/1LxSB6UEAVK0NLgU0ah5y0CBbD0gL_oO9/](https://drive.google.com/file/d/1f1iERQPWCxWpzUAjW22qMu-XrtnW8gls/view?usp=sharing) ).

Завдання - знайти наступні чотири/шість значень:
    1. максимальне число в файлі;
    2. мінімальне число в файлі;
    3. медіану ( https://goo.gl/hiCwVw );
    4. середнє арифметичне значення ( https://goo.gl/XJeAjZ );
    5*. найбільшу послідовність чисел (які ідуть один за одним), яка збільшується (опціонально)
    6*. найбільшу послідовність чисел (які ідуть один за одним), яка зменьшується (опціонально)

Запропонований метод рішення повинен знаходити всі чотири/шість величин з файлу не більше ніж за 90 секунд. Ця умова є необов'язковою, однак буде істотним плюсом, якщо ваше рішення буде її задовольняти.

Додаткова інформація:
- Медіана: Якщо в наборі чисел парна кількість елементів, то для визначення медіани повинна використовуватися півсума двох сусідніх значень. Тобто наприклад, у наборі {1, 8, 14, 19} медіаною буде 11 (бо 0.5*(8+14)=11).

- Послідовність чисел - це порядок чисел у файлі, що йдуть один за одним. Навіть випадкові генеровані набори даних можуть мати досить довгі послідовності. Наприклад, зростаюча послідовність може виглядати так: -4390, -503, 3, 16, 5032

Ви практично не обмежені у виборі методу та способу вирішення задачі. Ви можете використовувати будь-які засоби, методи, підходи (крім двох обмежень, що наведені нижче). Ви можете написати програму будь-якою відомою вам мовою програмування, або можете використовувати наявні програми/утиліти. Звісно, ви можете використовувати готові набори статистичних класів/функцій/бібліотек, але це не найкращий варіант.

Існують лише такі обмеження, які слід враховувати при виборі способу вирішення задачі:

Обмеження #1:
Будь-яка людина повинна мати можливість скористатися вашим методом. Це означає, наприклад, якщо для вирішення завдання Ви використовували свою власну програму, то будь-яка інша людина повинна мати можливість її скомпілювати/запустити і т.д.; якщо Ви використовували сторонні програми/утиліти, то будь-яка людина повинна мати можливість їх також встановити та користуватися; також будь-яка людина може взяти зовсім інший файл з іншим набором цілих чисел і знайти всі чотири вказані величини);
    
Обмеження #2:
при вирішенні задачі не можна використовувати нелегальне програмне забезпечення (пропрієтарне ПЗ, яке зазнало злому, піратські копії ПЗ, тощо). Також якщо ви запозичили ідею рішення, ПЗ або вихідні джерела (або якусь їх частину) у друга/колеги/в інтернеті/де-завгодно, то згадайте джерело.
