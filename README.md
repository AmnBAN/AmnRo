# AmnRo
!ابزاری برای ارسال امن فایل در محیط ناامن

:برای دانلود جدیدترین نسخه امن‌رو به لینک زیر مراجعه کنید

https://github.com/AmnBAN/AmnRo/releases

# راهنمای استفاده

![How to use](https://user-images.githubusercontent.com/50942920/66287105-42f2ba00-e8e1-11e9-8afb-09f2a826b194.gif)

# Change Log 
## Version [0.5.0]
-  Multi language (EN-FA) 
-  Smaller exe file

## Version [0.4.0] - 2021-8-12
### Fix
-  fix bug in password length 
- remove extra usings
- better UI

### Added
- Error provider to KeyGen Form

## Version [0.2.0] - 2019-10-24
### Added
- About from is added to project.
- Colorize froms.
- Escape and Enter keys is handled.
- Amnban public key is embeded.

### Changed
- extension of public key is changed from 'pub' to 'pubk'.

### Removed
- DLL files are removed and embeded to exe file.

## Version [0.1.0] - 2019-10-01
### Added
- The First release of AmnRo. 

# Libs

[Bouncy Castle](https://github.com/bcgit/bc-csharp)

[MaterialSkin](https://github.com/giansalex/MaterialSkin)

# ساختار فایل رمزنکاری شده 

- 20 بایت ابتدایی برای ورژن برنامه 
مثالی از ورژن : Amnro111
- 40 بایت برای پسوند فایل

> دقت کنید که حروف اسکی هر کدام یک بایت فضا میگیرند و حروف غیر اسکی هرکدام 2 بایت . پس طول پسوند نباید بیشتر از 20 حرف شود