# Урок 1 - Знакомство


## Домашнее задание

### Summary

Добавить требования к вашему годовому проекту в файле README.md в репозитории.

Deadline: Желательно к началу следующего урока, но если что-то не получится, ничего страшного, разберем вместе на уроке.

### Instructions

На уроке мы уже создали учетную запись в github, а также ваш первый репозиторий. Теперь нужно склонировтаь этот репозиторий себе на компьютер, создать (если он еще не создан) файл README.md, записать в него требования (использование формата MarkDown приветствуется, [вот тут сслыка, чтобы поситать про него](https://guides.github.com/features/mastering-markdown/)).

Чтобы заработал git в командной строке на вашем компьютере, нужно его установить. Вот инструкции:

#### Windows
1. Скачать Github Desktop отсюда: https://desktop.github.com/
2. Установить, но при установке нужно убедиться, что выбран вариант command line  

#### Linux
```
sudo apt-get install git
```

### Дальше все просто

Чтобы открыть командную строку в Windows, нажмите Win+R и наберите cmd + Enter
Чтобы открыть командную строку в Linux, нажмите Ctrl+Alt+T

Склонировать на локальный диск и зайти в папку с репозиторием:
```
git clone https://github.com/<ваш login>/<ваш репозиторий>
cd <ваш репозиторий>
```

Дальше нужно создать или открыть файл README.md в папке с репозиторием. На Linux это делается командой `gedit README.md`, дальше откроется текстовый редактор.
На Windows нужно зайти в папку репозитория при помощи Windows Explorer, если файл README.md существует, то нажать на него правой кнопкой мышки и выбрать "открыть в...", а, если не существует, то нажать по пустому месту в папке и выбрать "создать файл". Создавая его нужно убедиться, что Windows не добавил к файлу расширение .txt, иначе он не будет правильно отображаться в GitHub.

Добавить файл в коммит и создать коммит:
```
git add .
git commit -m "Added README"
```

Послать коммит на сервер:
```
git push
```