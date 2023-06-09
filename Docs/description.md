# Опис вимог до програми 

## Сценарії

### Сценарій 1. Пошук вкладу
#### Передумова
  Користувач відкрив головне вікно програми.
#### Основний сценарій
  1. Користувач заповнює поле пошуку.
  2. Програма знаходить вкладників, які задовольняють умовам пошуку.
  3. Користувач бачить список знайдених вкладників.
#### Додатковий сценарій
  1. Користувач заповнює поле пошуку.
  2. Програма не знаходить жодного вкладника, який задовольняє умовам пошуку.
  3. Користувач бачить повідомлення, що книг не знайдено.


---


### Сценарій 2. Додавання вкладу
#### Передумова
Користувач відкрив головне вікно програми.
#### Основний сценарій
1. Користувач натискає кнопку додавання вкладу.
2. Користувач заповнює поля у формі додавання вкладу і натискає кнопку "Додати".
3. Програма перевіряє коректність даних в полях, створює новий вклад і додає його до списку вкладів.
#### Додатковий сценарій
1. Користувач натискає кнопку додавання вкладу.
2. Користувач заповнює поля у формі додавання вкладу і натискає кнопку "Додати".
3. Програма встановлює, що дані не коректні.
4. Програма сповіщає користувача про помилку в даних і про те, в якому саме полі є помилка.


---


### Сценарій 3. Поповнення/зняття вкладу
#### Передумова
Користувач знайшов потрібний вклад.
#### Основний сценарій
1. Користувач натискає праву кнопку миші на потрібному вкладі та обирає пункт "Поповнити вклад" або "Зняти вклад".
2. Користувач заповнює поле у формі поповнення/зняття вкладу і натискає кнопку "Ок".
3. Програма перевіряє коректність даних в полях та поповнює або знімає гроші з вкладу.
#### Додатковий сценарій
1. Користувач натискає праву кнопку миші на потрібному вкладі та обирає пункт "Поповнити вклад" або "Зняти вклад".
2. Користувач заповнює поле у формі поповнення/зняття вкладу і натискає кнопку "Ок".
3. Програма встановлює, що дані не коректні.
4. Програма сповіщає користувача про помилку в даних.


---


### Сценарій 4. Редагування вкладу
#### Передумова
Користувач знайшов потрібний вклад.
#### Основний сценарій
1. Користувач натискає праву кнопку миші на потрібному вкладі та обирає пункт "Редагування вкладу".
2. Користувач заповнює поля у формі редагування вкладу і натискає кнопку "Редагувати".
3. Програма перевіряє коректність даних в полях та редагує дані вкладу.
#### Додатковий сценарій
1. Користувач натискає праву кнопку миші на потрібному вкладі та обирає пункт "Редагування вкладу".
2. Користувач заповнює поля у формі редагування вкладу і натискає кнопку "Редагувати".
3. Програма встановлює, що дані не коректні.
4. Програма сповіщає користувача про помилку в даних.


---


### Сценарій 5. Видалення вкладу
#### Передумова
Користувач знайшов потрібний вклад.
#### Основний сценарій
1. Користувач натискає праву кнопку миші на потрібному вкладі та обирає пункт "Видалити вклад".
2. Користувач натискає кнопку "Так" на діалоговомі вікні з підтвердженням видалення вкладу.
3. Програма видаляє вклад.
#### Додатковий сценарій
1. Користувач натискає праву кнопку миші на потрібному вкладі та обирає пункт "Редагування вкладу".
2. Користувач натискає кнопку "Ні" на діалоговомі вікні з підтвердженням видалення вкладу.
4. Програма не видаляє вклад.

## Функції

### Функція 1. Пошук вкладу
<details>
  <summary>Рисунок 1</summary>

<img src="/Docs/images/1.png" alt="Рисунок 1">

</details>
Поле пошуку розташовується зверху на головному вікні програми (рис 1).
В полі пошуку регістр не важливий. Відсутність даних в полі вводу означає, що будуть виведені всі вклади.
Результат пошуку буде показаний у вигляді списку знайдених вкладів на головному вікні програми нижче поля пошуку.
Кожний елемент списку містить номер вкладу, ім'я, прізвище, по-батькові, суму вкладу, % річних, дата останньої операції, дата останнього нарахування відсотків.
Якщо жодного вкладу не знайдено, замість списку книг користувач бачить повідомлення: "Не знайдено жодного вкладника".

---

### Функція 2. Додавання вкладу
<details>
  <summary>Рисунок 2</summary>

<img src="/Docs/images/2.png" alt="Рисунок 2">

</details>
Форма додавання вкладника (рис 2) з'являється при натисканні на кнопку "Додати вкладника" на головному вікні програми (рис 1).
Всі поля в формі повинні бути заповненими.
Якщо будь-яке поле не заповнено або заповнено не коректно, користувач бачить повідомлення про помилку.

---

### Функція 3. Редагування вкладу
<details>
  <summary>Рисунок 3</summary>

<img src="/Docs/images/3.png" alt="Рисунок 3">

</details>
Форма редагування вкладу (рис 3) з'являється при натисканні на пункт "Редагувати" у контекстному меню, яке визивається натисканням ПКМ по вкладу у списку вкладів у головному вікні програми (рис 1).
Всі поля в формі повинні бути заповненими.
Якщо будь-яке поле не заповнено або заповнено не коректно, користувач бачить повідомлення про помилку.


---

### Функція 4. Поповнення/зняття вкладу
<details>
  <summary>Рисунок 4</summary>

<img src="/Docs/images/4.png" alt="Рисунок 4">

</details>
Форма поповнення/зняття вкладу (рис 4) з'являється при натисканні на пункт "Поповнити вклад" або "Зняти з вкладу" у контекстному меню, яке визивається натисканням ПКМ по вкладу у списку вкладів у головному вікні програми (рис 1).
Поле суми попвнення/зняття в формі повинно бути заповненим.
Якщо поле не заповнено або заповнено не коректно, користувач бачить повідомлення про помилку.

---

### Функція 5. Видалення вкладу
Форма з запитом на видалення з'являється при натисканні на пункт "Видалити" у контекстному меню, яке визивається натисканням ПКМ по вкладу у списку вкладів у головному вікні програми (рис 1).
Форма містить текст "Ви впевнені що хочете видалити вклад №... (ПІБ)?" та кнопки "Так" та "Ні".