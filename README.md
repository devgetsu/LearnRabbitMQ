## Erlang va RabbitMQ o'rnatish bo'yicha qo'llanma

### 1. Erlang o'rnatish
Erlang dasturlash tilini o'rnatish uchun quyidagi amallarni bajaring:

1. [Erlang yuklab olish sahifasi](https://www.erlang.org/downloads)ga o'ting.
2. "Windows installer" tugmasini bosing va yuklab oling.
3. Yuklab olingan faylni ishga tushiring va o'rnatishni yakunlang.

### 2. RabbitMQ o'rnatish
RabbitMQ o'rnatish uchun quyidagi amallarni bajaring:

1. [RabbitMQ o'rnatish qo'llanmasi](https://www.rabbitmq.com/docs/install-windows-manual)ga o'ting.
2. Sahifadagi zip faylini yuklab oling va uni oching.

### 3. RabbitMQ sozlash
RabbitMQ papkangizning `sbin` papkasiga kiring va terminal oching. Quyidagi buyruqlarni kiriting:

```sh
rabbitmq-plugins.bat enable rabbitmq_management
rabbitmq-plugins.bat enable rabbitmq_shovel
```

Agar yuqoridagi buyruqlar ishlamasa, quyidagilarni sinab ko'ring:

```sh
./rabbitmq-plugins.bat enable rabbitmq_management
./rabbitmq-plugins.bat enable rabbitmq_shovel
```

### 4. RabbitMQ boshqaruv panelini tekshirish
Boshqaruv panelini ochish uchun quyidagi URL manziliga o'ting: [http://localhost:15672/#/](http://localhost:15672/#/)

#### Default Login:
- **Username:** `guest`
- **Password:** `guest`

Bu usullar orqali siz Erlang va RabbitMQ ni muvaffaqiyatli o'rnatishingiz mumkin.
