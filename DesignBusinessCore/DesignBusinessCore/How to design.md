﻿ผมคิดว่าการ design ก็ไม่ได้มีอะไรมากมาย คิดอะไรง่ายๆและได้ประสิทธิภาพก็พอ
ให้มองแบบนี้ คือ จะทำอะไร ให้ได้อะไร มองเป็น 1 ต่อ 1 เข้า 1 ออก 1

ที่นี้ Business Core ใน clean ก็ bussines logic ที่จะต้องเปลี่ยนเป็นโค้ด
ถ้าเคยลองแบ่ง 3 tier โดยมี infra มาก่อน จะรู้ได้เลยว่า business logic บางอย่าง
จะไปผูกอยู่กับ infra ในการใช้งานก็ dependency กันไปมันก็ไม่ได้แย่หรอก แต่มัน depen กันไง ????

แต่ถ้าลองมองคิดใหม่ ถ้า business logic คือคนกำหนดสิ่งที่จะมีได้ละ infra จะเขียนยังไง
business core จะเขียนยังไงมาลองกัน

โจทย์เราง่าย
- Ping

1) สร้าง interface ของ business logic ที่ต้องการ 1 ต่อ 1
2) สร้าง imprementation ของ business logic 
จาก 2) จะเห็นได้ว่าเราจะ imprementation ที่มีการทำงานด้านในต่างกันอย่างไรก็ได้ โดย business core หน้าตาจะไม่เปลี่ยนเลย

ที่นี้ลองนำไปใช้กับ infra ดูสิ ระบบจะ flexible มากขึ้้น

แต่ข้อเสียยอมมี หาก define business core ไม่ครบก็วุ่นวายอยู่เหมือนกัน




