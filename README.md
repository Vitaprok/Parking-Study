# About
## Project
Этот проект является учебным проектом по дисциплине "Разработка Мобильных Приложений". Проект находится в [Github](ttps://github.com/DiabloZX/Parking-Study), все новые версии, вся информация о проекте также находится там же. Само приложение разрабатывается на движке `Unity` версии `2020.3.26f1` на языке `C#`. Для создания спрайтов использовалось приложение `Aseprite`.

## App
Данное мобильное приложение создано с целью помочь владельцам авто в поиске парковочного места. 

Общий поток действий пользователей:
- Пользователь, который уже занял парковочное место, может создать предложение этого места, указав адрес и время, когда и где он освободит свое место. 
- Пользователь, который ищет парковочные места вблизи указанного места, может выбрать самое подходящее предложение о месте из предложенных системой и отправить владельцу места запрос на сделку. 
- Если же владелец места согласится на запрос, то будет создана сделка, которая будет вручную завершена пользователями после обмена парковочным местом.
- После завершения сделки, сдаваший место получает условные `бонусы` приложения от другого пользователя, которые занял место первого.

Также в приложении есть личный профиль, рейтинг, история сделок и возможность указать точные данные о своих автомобилях.

# Install project to your computer
Чтобы открыть проект на вашем компьютере, необходимо выполнить следующие вещи:
- Стянуть репозиторий к себе
- Установить нужную версию Unity (`2020.3.26f1`), например, через UnityHub.
- Открыть проект как существующий, указав папку Unity-проекта как корневую директорию проекта

# Current project status
В данный момент, проект находится на стадии созданного кликабельного макета с заглушками и без кода. Проект выполняет задание `Практической работы №2`, имея рабочий макет, который можно запустить через `apk-файл`.

# Download & Use


# Project objects examples
Ниже будут представлены примеры некоторых элементов, объектов, из которых состоит проект для мгновенного просмотра внутренней работы проекта без необходимости установки его себе.

### Весь проект состоит из 1 сцены: 

![Scene](./ScreenshotsForReadme/Scene.png)

___
### Сцена состоит из нескольких экранов: 
- Приветственная страница
- Страница входа
- Страница регистрации
- Домашняя страница 
- Страница поиска места
- Страница сдачи места
- Профиль пользователя
- Страница истории сделок

![Scene](./ScreenshotsForReadme/Pages.png)

___
### Пример использования элемента Scroll view: 

<img src="./ScreenshotsForReadme/SCroll-2.png" height="500"/>
<img src="./ScreenshotsForReadme/SCroll-1.png" height="500"/>
<img src="./ScreenshotsForReadme/SCroll-3.png" height="400"/>

___
### Пример экрана с картой: 

<img src="./ScreenshotsForReadme/Map.png"/>

___
### Пример использования маски для округления квадратных изображения аватара пользователя: 

<img src="./ScreenshotsForReadme/Avatar-1.png"/>
<img src="./ScreenshotsForReadme/Avatar-2.png" height="200"/>

___
### Пример использования маски для округления квадратных изображения аватара пользователя: 

<img src="./ScreenshotsForReadme/Avatar-1.png"/>
<img src="./ScreenshotsForReadme/Avatar-2.png" height="200"/>

___
### Пример использование якорей (Anchers) на элементах для верстки на разных размерах экранов: 

<img src="./ScreenshotsForReadme/Size-1.png" height="500"/>
<img src="./ScreenshotsForReadme/Size-2.png" height="500"/>

# Author
Проект выполнен студентом Сибирского Федерального Университета Института Космических и Информационных Технологий группы `КИ20-17/1Б` `Смыковым Алексеем`.

Мой [Github](ttps://github.com/DiabloZX)