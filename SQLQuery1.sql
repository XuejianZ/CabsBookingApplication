use [XuejianZhou.CabsBookingDb]
select *from Places
select *from CabTypes
select *from Bookings
select *from BookingsHistory
use [XuejianZhou.CabsBookingDb]
INSERT INTO [Places] VALUES('Chicago'),('NYC'),('Las Vegas'),('Las Angles'),('Atlanta'),('WashingtonDC'),('Bangor'),('State College'),('Philadelphia'),('Miami');
INSERT INTO CabTypes VALUES('Ford fiesta'),('Ford Focus'),('Honda Civic'),('Nissan Rouger'),('Nissan Altima'),('Nissan Murano'),('BMW 3'),('BMW 5'),('Mercedes-Benz-GLC'),('Mercedes-Benz-GLA');



INSERT INTO BookingsHistory([Email],[BookingDate],[BookingTime],[FromPlace],[ToPlace],[PickupAddress],[Landmark],[PickupDate],[PickupTime],[CabTypeId],[ContactNo],[Status],[comp_time],[charge],[Feedback]) 
VALUES('Proin@enimnec.com','02/28/2020','9AM','1','2','2901S Michiagn Ave','Southloop Station','02/10/2020','9AM',5,'1-780-561-7237','FullGas','20h','500','Nice Car! Very Comfortable,')

INSERT INTO BookingsHistory([Email],[BookingDate],[BookingTime],[FromPlace],[ToPlace],[PickupAddress],[Landmark],[PickupDate],[PickupTime],[CabTypeId],[ContactNo],[Status],[comp_time],[charge],[Feedback]) 
VALUES('Mike@gmail.com','03/01/2020','10AM','3','4','21S Indiana Ave','Burger King','03/02/2020','10AM',8,'1-780-561-7237','FullGas','4h','350','Nice Trip,')


 
 
INSERT INTO BookingsHistory([Email],[BookingDate],[BookingTime],[FromPlace],[ToPlace],[PickupAddress],[Landmark],[PickupDate],[PickupTime],[CabTypeId],[ContactNo],[Status],[comp_time],[charge],[Feedback]) 
VALUES('Allen@gmail.com','03/01/2020','10AM','3','4','21S Indiana Ave','Burger King','03/02/2020','10AM',8,'1-780-561-7237','FullGas','4h','350','Nice Trip,'),
('John@gmail.com','03/02/2020','10AM','6','7','21S Indiana Ave','Burger King','03/02/2020','10AM',8,'1-780-561-7237','FullGas','4h','350','Nice Trip,'),
('Amy@gmail.com','03/03/2020','10AM','5','8','21S Indiana Ave','Burger King','03/02/2020','10AM',7,'1-780-561-7237','FullGas','4h','350','Nice Trip,'),
('Hunag@gmail.com','03/04/2020','10AM','6','9','21S Indiana Ave','Burger King','03/02/2020','10AM',2,'1-780-561-7237','FullGas','4h','350','Nice Trip,')


 


INSERT INTO Bookings([Email],[BookingDate],[BookingTime],[FromPlace],[ToPlace],[PickupAddress],[Landmark],[PickupDate],[PickupTime],[CabTypeId],[ContactNo],[Status]) 
VALUES('Proin@enimnec.com','02/28/2020','9AM','1','2','2901S Michiagn Ave','Southloop Station','02/10/2020','9AM',5,'1-780-561-7237','FullGas'),
('Mike@gmail.com','03/01/2020','10AM','3','4','21S Indiana Ave','Burger King','03/02/2020','10AM',6,'1-780-561-7237','FullGas')


INSERT INTO Bookings([Email],[BookingDate],[BookingTime],[FromPlace],[ToPlace],[PickupAddress],[Landmark],[PickupDate],[PickupTime],[CabTypeId],[ContactNo],[Status]) 
VALUES('123@enimnec.com','03/20/2020','9AM','1','2','2901S Michiagn Ave','Southloop Station','04/10/2020','9AM',10,'1-780-561-7237','FullGas'),
('allen@enimnec.com','04/21/2020','9AM','2','3','2901S Michiagn Ave','Southloop Station','05/10/2020','9AM',10,'1-780-561-7237','FullGas'),
('mary@enimnec.com','05/22/2020','9AM','4','5','2901S Michiagn Ave','Southloop Station','06/10/2020','9AM',7,'1-780-561-7237','FullGas'),
('jimmy@enimnec.com','06/23/2020','9AM','6','7','2901S Michiagn Ave','Southloop Station','07/10/2020','9AM',1,'1-780-561-7237','FullGas'),
('wang@enimnec.com','07/24/2020','9AM','5','7','2901S Michiagn Ave','Southloop Station','08/10/2020','9AM',5,'1-780-561-7237','FullGas'),
('lan@enimnec.com','08/25/2020','9AM','2','4','2901S Michiagn Ave','Southloop Station','09/10/2020','9AM',9,'1-780-561-7237','FullGas')