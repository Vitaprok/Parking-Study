# About
## Project
Этот проект является учебным проектом по дисциплине "Разработка Мобильных Приложений". Проект находится в [Github](https://github.com/DiabloZX/Parking-Study), все новые версии, вся информация о проекте также находится там же. Само приложение разрабатывается на движке `Unity` версии `2020.3.26f1` на языке `C#`. Для создания спрайтов использовалось приложение `Aseprite`.

## App
Данное мобильное приложение создано с целью помочь владельцам авто в поиске парковочного места. 

Общий поток действий пользователей:
- Пользователь, который уже занял парковочное место, может создать предложение этого места, указав адрес и время, когда и где он освободит свое место. 
- Пользователь, который ищет парковочные места вблизи указанного места, может выбрать самое подходящее предложение о месте из предложенных системой и отправить владельцу места запрос на сделку. 
- Если же владелец места согласится на запрос, то будет создана сделка, которая будет вручную завершена пользователями после обмена парковочным местом.
- После завершения сделки, сдаваший место получает условные `бонусы` приложения от другого пользователя, которые занял место первого.

Также в приложении есть личный профиль, рейтинг, история сделок и возможность указать точные данные о своих автомобилях.

## Author
Проект выполнен студентом Сибирского Федерального Университета Института Космических и Информационных Технологий группы `КИ20-17/1Б` `Смыковым Алексеем`.

Мой [Github](https://github.com/DiabloZX)

# Install project to your computer for development
Чтобы открыть проект на вашем компьютере, необходимо выполнить следующие вещи:
- Для начала, нужно установить `UnityHub`
  Это приложение будет использоваться в дальнейшем для установки нужной нам версии Unity.
  Для установки приложения на `Linux`, на [официальном сайте](https://unity.com/ru/download) можно выбрать версию и для этой ОС. 
  Для установки на дистрибутив openSUSE, можно воспользоваться следующими ссылками:
  - [Установить через `Flatpac`](https://flathub.org/apps/details/com.unity.UnityHub)
  - [Ссылки на скачивание `.rpm` файла](https://hub-dist.unity3d.com/artifactory/hub-rpm-prod-local/unity/stable/unityhub_x86_64/)
  - [Документация Unity по установке на линукс](https://docs.unity3d.com/ru/2019.4/Manual/GettingStartedInstallingHub.html)
  - [Тред ](https://github.com/JetBrains/teamcity-unity-plugin/issues/67)
  
- Следующим шагом, нужно установить нужную `конкретно эту` версию движка Unity, чтобы мы могли запустить проект через UnityHub
  ![image](https://user-images.githubusercontent.com/74893461/225151297-5904ce98-2024-4614-9920-c809c94b320e.png)
  По следующей [ссылке](https://unity.com/releases/editor/archive) переходим на сайт архива версий Unity, т.к. в UnityHub не найти нужную нам версию, и выбираем ее для
  установки через UnityHub:
  ![image](https://user-images.githubusercontent.com/74893461/225152379-da92f7ea-c40c-4e37-b646-063ed7bfd0d5.png)
  После установки, версия должна отображаться в UnityHub, как на скриншоте выше.
  
- Теперь необходимо открыть в Unity этот проект, для этого его нужно стянуть (клонировать) себе на ПК в пустую директорию.

- Далее, необходимо открыть проект в UnityHub, выбрав папку с проектом:
  ![image](https://user-images.githubusercontent.com/74893461/225153417-230b288b-2c42-4650-9e46-07acb685b85b.png)
  Или же это можно сделать через консоль:
  
  Windows
  ```shell
  "<path_to_version>\Editor\Unity.exe" -projectPath "<project path>"
  ```
  Пример пути до Unity:
  ```shell
  "C:\Program Files\Unity\Hub\Editor\2020.3.26f1\Editor\Unity.exe" -projectPath "<project path>"
  ```
  
  Linux
  ```bash
  <path_to_version>/Unity.app/Contents/Linux/Unity -projectPath <project path>
  ```
  
  Пример пути до Unity:
  ```bash
  /Applications/Unity/Hub/Editor/2020.3.26f1/Unity.app/Contents/Linux/Unity -projectPath <project path>
  ```
  Точнее можно посмотреть [здесь](https://docs.unity3d.com/Manual/EditorCommandLineArguments.html)
  
  После добавления проекта, он сохранится в UnityHub для быстрого запуска в следующим раз, а также начнет запускаться сам проект
  ![image](https://user-images.githubusercontent.com/74893461/225153792-d4765bfa-8ecb-4ece-9c07-2958007f76ce.png)
  
- После загрузки, вам должно открыться окно с примерно таким содержанием: 
  ![image](https://user-images.githubusercontent.com/74893461/225153954-f7ac475b-b596-45da-9bb1-ca4ccc59605e.png)
  Если же на `сцене` ничего нет, то необходимо выбрать нужную сцену (она всего одна) из списка сцен:
  ![image](https://user-images.githubusercontent.com/74893461/225154204-e8b7b9cd-17ea-49e1-94ea-d991a6beceff.png)




# Current project status
В данный момент, проект находится на стадии созданного кликабельного макета с заглушками и без кода. Проект выполняет задание `Практической работы №2`, имея рабочий макет, который можно запустить через `apk-файл`.

# Download & Use
Скачать последнюю версию вы можете по следующим ссылкам:
- [apk](https://github.com/DiabloZX/Parking-Study/releases/download/Latest/Parking.0.0.6.apk)
- [Release](https://github.com/DiabloZX/Parking-Study/releases/tag/Latest)
- [Source code zip](https://github.com/DiabloZX/Parking-Study/archive/refs/tags/Latest.zip)
- [Source code tar.gz](https://github.com/DiabloZX/Parking-Study/archive/refs/tags/Latest.tar.gz)

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
### Пример использование якорей (Anchers) на элементах для верстки на разных размерах экранов: 

<img src="./ScreenshotsForReadme/Size-1.png" height="500"/>
<img src="./ScreenshotsForReadme/Size-2.png" height="500"/>
