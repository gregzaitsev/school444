# Боевая настройка веб-сайта

## Сервер

Вам (будет) выделена отдельная машина, виртуальный сервер (VPS). На ней установлена операционная система Ubuntu Server 18.04.

Доступ к серверу осуществляется через протокол SSH. Имя пользователя: `root`. Чтобы получить адрес, Ваш SSH порт и пароль, напишите мне в личку.

Дальше все зависит от операционной системы, с которой Вы будете на этот сервер заходить.

### Windows

Нужно установить утилиту putty, скачав отсюда: https://www.putty.org/

Как с ней обращаться написано вот тут: https://www.hostland.ru/help/instructions/putty

### Linux

Тут все проще, есть встроенная утилита ssh, поэтому команда в терминале выглядит так:
```
# нужно заменить 2201 на Ваш номер порта
ssh root@45.143.137.181 -p2201
```
Дальше утилита спросит Ваш пароль и Вы на сервере!

## Контейнеризация

В качестве теории прочитайте вот эту замечательную серию статей про docker: https://habr.com/ru/company/ruvds/blog/438796/
(Если все понятно и скучно, можно ограничиться чтением 3й части)

## Задание

1. Установить на своем сервере docker CE при помощи этих инструкций:
https://www.digitalocean.com/community/tutorials/how-to-install-and-use-docker-on-ubuntu-18-04

2. Создать Dockerfile и запустить на своем сервере сайт по этой статье:
https://habr.com/ru/company/ruvds/blog/440656/

Дальше можете делать с сайтом все, что угодно, если это не противоречит законам РФ. Хостинг проплачен на 2 месяца вперед. Если понадобится длительное использование, дайте знать, придумаем как передать сервер.