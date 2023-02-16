# امن رو
ابزاری ساده و سریع برای رمزگذاری فایل بر پایه PGP

برای دانلود جدیدترین نسخه امن‌رو به [اینجا](https://github.com/AmnBAN/AmnRo/releases/latest) مراجعه کنید.

AmnRo fast and simple tool for encrypt file based on PGP

For download latest version go to [Release page](https://github.com/AmnBAN/AmnRo/releases/latest).

# راهنمای استفاده

![How to use](https://user-images.githubusercontent.com/50942920/66287105-42f2ba00-e8e1-11e9-8afb-09f2a826b194.gif)

# Usage
- Download AmnRo from [Release page](https://github.com/AmnBAN/AmnRo/releases/latest).
- Run it
- Change language to English!
- Generate Keys
- Save **Private key**
- Give **Public key** to others
- Other peoples can encrypt files with your **Public key** and you can decypt them with **Private key** .

# Libs

[Bouncy Castle](https://github.com/bcgit/bc-csharp)

[MaterialSkin](https://github.com/giansalex/MaterialSkin)

# ساختار فایل رمزنگاری شده 

- 20 بایت ابتدایی برای ورژن برنامه 
> مثالی از ورژن : Amnro111

- 40 بایت بعدی برای پسوند فایل
> دقت کنید که حروف اسکی هر کدام یک بایت فضا میگیرند و حروف غیر اسکی هرکدام 2 بایت . پس طول پسوند نباید بیشتر از 20 حرف شود
