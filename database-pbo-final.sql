CREATE TABLE IF NOT EXISTS akun_admin (
    id_akun_admin SERIAL PRIMARY KEY,
    username VARCHAR(30) NOT NULL,
    password VARCHAR(10) NOT NULL,
    email VARCHAR(254) NOT NULL,
    no_hp VARCHAR(50) NOT NULL
);

INSERT INTO akun_admin(id_akun_admin,username,password,email,no_hp) 
VALUES 
(DEFAULT,'yudha','yudha123','yudha@gmail.com',6281425262156),
(DEFAULT,'zaidan','zaidan123','zaidan@gmail.com',6281231412421),
(DEFAULT,'wildan','wildan123','wildan@gmail.com',6281241579231);

select * from akun_admin


CREATE TABLE IF NOT EXISTS akun_user (
    id_akun_user SERIAL PRIMARY KEY,
    username VARCHAR(30) NOT NULL
);

INSERT INTO akun_user(id_akun_user,username) 
VALUES 
(DEFAULT,'tama123'),
(DEFAULT,'yuda123'),
(DEFAULT,'handoko');

select * from akun_user

CREATE TABLE IF NOT EXISTS transaksi (
    id_transaksi SERIAL PRIMARY KEY,
    tanggal_transaksi TIMESTAMP WITHOUT TIME ZONE DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO transaksi (tanggal_transaksi)
VALUES ('2023-06-10 07:44:00'),
       ('2023-06-10 07:50:00'),
       ('2023-06-10 07:53:00'),
       ('2023-06-10 07:58:00'),
       ('2023-06-10 08:11:00');

select * from transaksi

CREATE TABLE IF NOT EXISTS layanan_darurat (
    id_layanan_darurat SERIAL PRIMARY KEY,
    nama_layanan_darurat VARCHAR(50) NOT NULL,
    no_telp VARCHAR(50) NOT NULL,
    email_layanan_daurat VARCHAR(254) NOT NULL,
    deskripsi_layanan_darurat TEXT NOT NULL
);

INSERT INTO layanan_darurat (id_layanan_darurat,nama_layanan_darurat,no_telp,email_layanan_daurat,deskripsi_layanan_darurat) 
VALUES 
(DEFAULT,'Pemadam Kebakaran','62814-7213-8632','pemadamkebakaran@gmail.com','Layanan darurat untuk Pemadam Kebakaran'),
(DEFAULT,'Pertolongan Medis','62814-8214-9724','medis@gmail.com','Layanan darurat untuk Pertolongan Medis'),
(DEFAULT,'Bantuan Wisata','62817-4215-2156','bantuan@gmail.com','Layanan darurat untuk Bantuan Wisata');

select * from layanan_darurat

CREATE TABLE IF NOT EXISTS harga_tiket (
    id_harga_tiket SERIAL PRIMARY KEY,
    harga_tiket INT NOT NULL
);

INSERT INTO harga_tiket (harga_tiket)
VALUES (7500),
       (10000);

select * from harga_tiket


CREATE TABLE IF NOT EXISTS jenis_fasilitas (
    id_jenis_fasilitas SERIAL PRIMARY KEY,
    nama_jenis_fasilitas VARCHAR(255) NOT NULL,
    deskripsi_jenis_fasilitas TEXT NOT NULL
);

INSERT INTO jenis_fasilitas(id_jenis_fasilitas, nama_jenis_fasilitas, deskripsi_jenis_fasilitas)
	VALUES (1, 'Kolam renang', 'Memiliki dua jenis kolam dengan satu kolam renang untuk anak dan satu kolam renang untuk orang dewasa'),
	       (2, 'Hotel', 'Memiliki 45 kamar dengan fasilitas yang dirancang untuk memberikan pengalaman penginapan yang berkualitas serta menawarkan pemandangan dari puncak yang menakjubkan'),
		   (3, 'Music corner', 'Merupakan fasilitas baru yang menawarkan pengalaman hiburan musik. Pada hari kerja disediakan fasilitas untuk karaoke dan pada akhir pekan akan ada penampilan live music untuk menghibur para pengunjung'),
		   (4, 'Camping ground', 'Fasilitas ini disediakan untuk pengalaman camping dengan suasana alam terbuka disertai pemandangan yang menakjubkan'),
		   (5, 'Restoran', 'Restoran ini membuat pengunjung dapat menikmati makanan yang lezat disertai pemandangan yang indah'),
		   (6, 'Cafe', 'Tempat yang nyaman untuk pengunjung menikmati makanan ringan dengan pemandangan dari puncak yang memanjakan mata');

select * from jenis_fasilitas

CREATE TABLE IF NOT EXISTS nama_tempat (
    id_nama_tempat SERIAL PRIMARY KEY,
    nama_tempat VARCHAR(255) NOT NULL,
    deskripsi_nama_tempat TEXT NOT NULL
);

INSERT INTO nama_tempat (id_nama_tempat, nama_tempat, deskripsi_nama_tempat)
VALUES
    (1, 'Resto Rembangan', 'Tempat makan yang pas untuk bersantai bersama keluarga, teman, pacar dengan view puncak kota jember yang memukau'),
    (2, 'Cafe Buah Naga', 'Cafe buah naga, cafe yang pas untuk bersantai di daerah puncak dengan ditemani kebun buah naga di sekitar cafe serta view puncak kota jember yang menyejukkan mata');

select * from nama_tempat

CREATE TYPE jenis_pengunjung_type AS ENUM('anak-anak','dewasa');
CREATE TABLE IF NOT EXISTS jenis_pengunjung (
    id_jenis_pengunjung SERIAL PRIMARY KEY,
    kelompok_usia jenis_pengunjung_type NOT NULL
);

INSERT INTO jenis_pengunjung (kelompok_usia) VALUES
    ('anak-anak'),
    ('dewasa');

select * from jenis_pengunjung


CREATE TABLE IF NOT EXISTS data_pengunjung (
    id_data_pengunjung SERIAL PRIMARY KEY,
    nama_pengunjung VARCHAR(255) NOT NULL,
    alamat_pengunjung VARCHAR(255) NOT NULL,
    jumlah_pengunjung INT NOT NULL,
    id_jenis_pengunjung INT NOT NULL,
    foreign key(id_jenis_pengunjung) references jenis_pengunjung (id_jenis_pengunjung)
);

INSERT INTO data_pengunjung (id_data_pengunjung, nama_pengunjung, alamat_pengunjung, jumlah_pengunjung, id_jenis_pengunjung)
VALUES
    (1, 'Yuliana', 'Ambulu', 1, 1),
    (2, 'Saiful', 'Probolinggo', 1, 2),
    (3, 'Ambar', 'Patrang', 1, 1),
    (4, 'Lubis', 'Medan', 1, 2),
    (5, 'Budi', 'Lumajang', 1, 1),
    (6, 'Nafa', 'Arjasa', 1, 2),
    (7, 'Alum', 'Arjasa', 1,1),
    (8, 'Fiki', 'Arjasa', 1, 2),
    (9, 'Suyono', 'Bintaro', 1,2),
    (10, 'Mulyadi', 'Jember', 1, 2);

select * from data_pengunjung

CREATE TABLE IF NOT EXISTS detail_transaksi (
    id_detail_transaksi SERIAL PRIMARY KEY,
    nominal_transaksi VARCHAR(50) NOT NULL,
    id_data_pengunjung INT NOT NULL,
    id_harga_tiket INT NOT NULL,
    id_transaksi INT NOT NULL,
    foreign key(id_data_pengunjung) references data_pengunjung (id_data_pengunjung),
	foreign key (id_harga_tiket) references harga_tiket (id_harga_tiket),
	foreign key (id_transaksi) references transaksi (id_transaksi)
);

INSERT INTO detail_transaksi (nominal_transaksi,id_data_pengunjung,id_harga_tiket,id_transaksi)
VALUES 
	('7500',1,1,1),
	('10000',2,2,2),
	('7500',3,1,3),
	('10000',4,2,4),
	('7500',5,1,5),
	('10000',6,2,3),
	('7500',7,1,4),
	('10000',8,2,5),
	('10000',9,2,1),
	('10000',10,2,2)
;

select * from detail_transaksi

CREATE TABLE IF NOT EXISTS cetak_nota (
    id_cetak_nota SERIAL PRIMARY KEY,
    id_detail_transaksi INT NOT NULL,
    foreign key(id_detail_transaksi) references detail_transaksi(id_detail_transaksi)
);

INSERT INTO cetak_nota (id_cetak_nota,id_detail_transaksi)
VALUES 
	(1,1),
	(2,2),
	(3,3),
	(4,4),
	(5,5),
	(6,6),
	(7,7),
	(8,8),
	(9,9),
	(10,10)
;

select * from cetak_nota

CREATE TABLE IF NOT EXISTS fasilitas (
    id_fasilitas SERIAL PRIMARY KEY,
    nama_fasilitas VARCHAR(255) NOT NULL,
    jumlah_fasilitas INT NOT NULL,
	harga_fasilitas VARCHAR(255) NOT NULL,
	jam_operational VARCHAR(255) NOT NULL,
	deskripsi_fasilitas VARCHAR(255)DEFAULT NULL,
    id_jenis_fasilitas INT NOT NULL,
    foreign key (id_jenis_fasilitas) references jenis_fasilitas (id_jenis_fasilitas)
);

INSERT INTO fasilitas (id_fasilitas,nama_fasilitas,jumlah_fasilitas,harga_fasilitas,jam_operational,deskripsi_fasilitas,id_jenis_fasilitas) 
VALUES 
(1,'Kolam renang anak',1,'Free','07:00-10:00',DEFAULT,1),
(2,'Kolam renang dewasa',1,'Free','07:00-10:00',DEFAULT,1),
(3,'Suite Room',1,'1635000','24 Jam','In 14.00 out  12.00',2),
(4,'Melati I',1,'445000','24 Jam','In 14.00 out 12.00',2),
(5,'Melati II',12,'385000','24 Jam','In 14.00 out 12.00',2),
(6,'Melati III',4,'265000','24 Jam','In 14.00 out 12.00',2),
(7,'Dahlia I',4,'265000','24 Jam','In 14.00 out 12.00',2),
(8,'Dahlia II',8,'265000','24 Jam','In 14.00 out 12.00',2),
(9,'Mawar I',8,'205000','24 Jam','in 14.00 out 12.00',2),
(10,'Mawar II',8,'205000','24 Jam','14.00 out 12.00',2),
(11,'Aula A',1,'1.155.000','07.00-23.00',DEFAULT,2),
(12,'Aula B',1,'Rp990.000','07.00-23.00',DEFAULT,2),
(13,'Musik Corner',1,'Free','07-00-22.00',DEFAULT,3),
(14,'Camping Ground',1,'50000-200000','24 Jam',DEFAULT,4);

select * from fasilitas

CREATE TABLE IF NOT EXISTS feedback_user (
    id_feedback_user SERIAL PRIMARY KEY,
    ulasan VARCHAR(255) DEFAULT NULL,
    rating INTEGER NOT NULL,
    tanggal_feedback DATE NOT NULL,
	id_akun_user int not null,
	foreign key (id_akun_user) references akun_user (id_akun_user)
);

INSERT INTO feedback_user (ulasan, rating, tanggal_feedback, id_akun_user)
VALUES 
	('Pelayanan sangat memuaskan!', 5, '2023-06-14', 1),
	('Perlu peningkatan dalam kecepatan respon.', 3, '2023-06-12', 2),
	('Sangat puas dengan produk yang ditawarkan!', 4, '2023-06-10', 3);
	
select * from feedback_user


CREATE TABLE IF NOT EXISTS kuliner (
    id_kuliner SERIAL PRIMARY KEY,
    nama_kuliner VARCHAR(255) NOT NULL,
    harga_kuliner INT NOT NULL,
    id_nama_tempat INT NOT NULL,
    foreign key (id_nama_tempat) references nama_tempat (id_nama_tempat)
);

INSERT INTO kuliner(
	id_kuliner, nama_kuliner, harga_kuliner, id_nama_tempat)
	VALUES (1, 'Kepiting Telur Asin / ons', 38000, 1),
		   (2, 'Kepiting Asam Manis / ons', 35000, 1),
		   (3, 'Cumi Telur Asin', 62000, 1),
		   (4, 'Cumi Saos Mentega', 58000, 1),
		   (5, 'Cumi Asam Manis', 57000, 1),
		   (6, 'Udang Telor Asin', 62000, 1),
		   (7, 'Udang Saos Mentega', 58000, 1),
		   (8, 'Udang Asam Manis', 57000, 1),
		   (9, 'Gurami (fillet) Asam Manis', 57000, 1),
		   (10, 'Ayam Bumby Pedas Satu Ekor', 90000, 1),
		   (11, 'Ayam Panggang Satu Ekor', 87000, 1),
		   (12, 'Ayam Goreng Satu ekor', 84000, 1),
		   (13, 'Ayam Goreng Lalapan + Nasi', 36000, 1),
		   (14, 'Fu Yung Hai', 55000, 1),
		   (15, 'Sup Merah', 52000, 1),
		   (16, 'Sup Ayam Jamur', 52000, 1),
		   (17, 'Cah Ayam Jamur', 42000, 1),
		   (18, 'Cap Jay Kuah', 32000, 1),
		   (19, 'Cap Jay Goreng', 29000, 1),
		   (20, 'Nasi Ikan Pedas', 29000, 1),
		   (21, 'Nasi Goreng Jawa + Telur', 29000, 1),
		   (22, 'Nasi Ceker Pedas', 23000, 1),
		   (23, 'Nasi Goreng Biasa + Telur', 24000, 1),
		   (24, 'Nasi Soto Ayam', 24000, 1),
		   (25, 'Mie Goreng / Kuah + Telur', 24000, 1),
		   (26, 'Bihun Goreng / Kuah + Telur', 24000, 1),
		   (27, 'Cah Sayur Kangkung', 20000, 1),
		   (28, 'Cah Sayur Sawi', 20000, 1),
		   (29, 'Sambal Lalapan', 10000, 1),
		   (30, 'Telur Ceplok / Dadar / Rebus', 7000, 1),
		   (31, 'Nasi Putih', 7000, 1),
		   (32, 'Mie Cup', 6000, 1),
		   (33, 'Kepiting Telur Asin / ons', 38000, 1),
		   (34, 'Kepiting Asam Manis / ons', 35000, 1),
		   (35, 'Cumi Telur Asin', 62000, 1),
		   (36, 'Cumi Saos Mentega', 58000, 1),
		   (37, 'Cumi Asam Manis', 57000, 1),
		   (38, 'Udang Telor Asin', 62000, 1),
		   (39, 'Udang Saos Mentega', 58000, 1),
		   (40, 'Udang Asam Manis', 57000, 1),
		   (41, 'Gurami (fillet) Asam Manis', 57000, 1),
		   (42, 'Ayam Bumby Pedas Satu Ekor', 90000, 1),
		   (43, 'Ayam Panggang Satu Ekor', 87000, 1),
		   (44, 'Ayam Goreng Satu ekor', 84000, 1),
		   (45, 'Ayam Goreng Lalapan + Nasi', 36000, 1),
		   (46, 'Fu Yung Hai', 55000, 1),
		   (47, 'Sup Merah', 52000, 1),
		   (48, 'Sup Ayam Jamur', 52000, 1),
		   (49, 'Cah Ayam Jamur', 42000, 1),
		   (50, 'Cap Jay Kuah', 32000, 1),
		   (51, 'Cap Jay Goreng', 29000, 1),
		   (52, 'Nasi Ikan Pedas', 29000, 1),
		   (53, 'Nasi Goreng Jawa + Telur', 29000, 1),
		   (54, 'Nasi Ceker Pedas', 23000, 1),
		   (55, 'Nasi Goreng Biasa + Telur', 24000, 1),
		   (56, 'Nasi Soto Ayam', 24000, 1),
		   (57, 'Mie Goreng / Kuah + Telur', 24000, 1),
		   (58, 'Bihun Goreng / Kuah + Telur', 24000, 1),
		   (59, 'Cah Sayur Kangkung', 20000, 1),
		   (60, 'Cah Sayur Sawi', 20000, 1),
		   (61, 'Sambal Lalapan', 10000, 1),
		   (62, 'Telur Ceplok / Dadar / Rebus', 7000, 1),
		   (63, 'Nasi Putih', 7000, 1),
		   (64, 'Mie Cup', 6000, 1),
		   (65, 'Susu Telur Madu Jahe', 22000, 1),
		   (66, 'Es Susu Soda / Cola', 18000, 1),
		   (67, 'Es Susu Coklat', 16000, 1),
		   (68, 'Es Susu Segar', 15000, 1),
		   (69, 'Es Jeruk Manis', 15000, 1),
		   (70, 'Es Jeruk Nipis', 15000, 1),
		   (71, 'Es Teh Jahe', 15000, 1),
		   (72, 'Susu Kopi', 15000, 1),
		   (73, 'Susu Coklat', 15000, 1),
		   (74, 'Susu Segar', 14000, 1),
		   (75, 'Kopi Jahe', 12000, 1),
		   (76, 'Kopi Hitam', 10000, 1),
		   (77, 'Teh Jahe', 10000, 1),
		   (78, 'Jahe Panas', 10000, 1),
		   (79, 'Es Teh', 8000, 1),
		   (80, 'Teh Manis', 8000, 1),
		   (81, 'Air Panas', 3000, 1),
		   (82, 'Es Batu', 2000, 1),
		   (83, 'Pisang Goreng Keju Spesial', 31000, 1),
       	   (84, 'Pisang Goreng Keju', 27000, 1),
           (85, 'Stick Kentang', 24000, 1),
           (86, 'Stick Singkong', 18000, 1),
           (87, 'Ketela Goreng', 18000, 1),
           (88, 'roti Bakar', 15000, 1),
		   (89, 'Nasi Rawon', '15000', 2),
           (90, 'Nasi Soto', 12000, 2),
		   (91, 'Lalapan Ayam Potong', 15000, 2),
		   (92, 'Lalapan Ayam Kampung', 25000,2),
		   (93, 'Lalapan Sayap', 13000, 2),
		   (94, 'Lalapan Rempelo Ati', 12000, 2),
		   (95, 'Lalapan Lele', 12000, 2),
		   (96, 'Lalapan Tempe Penyet', 10000, 2),
		   (97, 'Lalapan Tahu Penyet', 10000, 2),
		   (98, 'Lalapan Telur Penyet', 10000, 2),
		   (99, 'Nasi Pecel', 10000, 2),
		   (100, 'Nasi Ceker Pedas', 12000, 2),
		   (101, 'Nasi Sayap Pedas', 12000, 2),
		   (102, 'Nasi Goreng', 10000, 2),
		   (103, 'Nasi Putih', 5000, 2),
		   (104, 'Bakso', 10000, 2),
		   (105, 'Mie Kuah Isi Satu', 6000, 2),
		   (106, 'Mie Kuah Isi Dua', 8000, 2),
		   (107, 'Mie Goreng Isi Satu', 6000, 2),
		   (108, 'Mie Goreng Isi Dua', 8000, 2),
		   (109, 'Pop Mie', 10000, 2),
		   (110, 'Tambah Telur', 3000, 2),
		   (111, 'Sosis Panggang' ,10000 , 2),
		   (112, 'Kentang Goreng' ,10000 , 2),
		   (113, 'Singkong Goreng' ,5000 , 2),
		   (114, 'Stick Singkong' ,5000 , 2),
		   (115, 'Sosis Goreng' ,5000 , 2),
		   (116, 'Nugget Goreng' ,5000 , 2),
		   (117, 'Ketela Goreng' ,5000 , 2),
		   (118, 'Omelet' ,10000 , 2), 
		   (119, 'Roti Panggang' ,7000 , 2),
		   (120, 'Pisang Bakar' ,10000 , 2 ),
		   (121, 'Pisang Goreng' ,5000 , 2),
		   (122, 'Tempe Goreng' ,5000 , 2),
		   (123, 'Tahu Goreng' ,5000 , 2),
		   (124, 'Es Susu Segar', 8000,2),
		   (125, 'Es Teh', 6000, 2),
		   (126, 'Lemon Tea', 8000,2),
		   (127, 'Es Jeruk', 6000,2),
		   (128, 'Cappucino', 6000,2),
		   (129, 'Milo', 7000,2),
		   (130, 'Chocolatos', 6000,2),
		   (131, 'White Coffee', 6000,2),
		   (132, 'Creamy Latte', 6000,2),
		   (133, 'Susu Indomilk', 6000,2),
		   (134, 'Soda gembira', 10000,2),
		   (135, 'Joshua', 7000,2),
		   (136, 'Kubisu', 5000,2),
		   (137, 'ExtraJoss', 5000,2),
		   (138, 'KukuBima', 5000,2),
		   (139, 'Hemaviton', 5000,2),
		   (140, 'Nutrisari', 5000,2),
		   (141, 'Nutrisu', 6000,2),
		   (142, 'Pop Ice', 5000,2),
		   (143, 'Tebs', 7000,2),
		   (144, 'Fanta', 7000,2),
		   (145, 'Sprite', 7000,2),
		   (146, 'Fruit Tea', 6000,2),
		   (147, 'Segar Dingin', 5000,2),
		   (148, 'Jasjus', 4000,2),
		   (149, 'Kopi Hitam', 4000,2),
		   (150, 'Kopi Susu', 5000,2),
		   (151, 'Kopi Jahe', 5000,2),
		   (152, 'Susu Segar Gelas Kecil', 6000,2),
		   (153, 'Susu Segar Gelas Besar', 10000,2),
		   (154, 'Susu Segar Jahe Gelas Kecil', 7000,2),
		   (155, 'Susu Segar Jahe Gelas Besar', 12000,2),
		   (156, 'Teh Panas', 5000,2),
		   (157, 'Teh Jahe', 7000,2),
		   (158, 'Lemon Tea Hot', 7000,2),
		   (159, 'Wedang Jahe', 5000,2),
		   (160, 'Susu Jahe', 5000,2),
		   (161, 'Jeruk Panas', 5000,2),
		   (162, 'Capucino', 5000,2),
		   (163, 'Milo', 6000,2),
		   (164, 'Chocolatos', 5000,2),
		   (165, 'White Coffee', 5000,2),
		   (166, 'Creamy Latte', 5000,2),
		   (167, 'Susu Indomilk', 5000,2),
		   (168, 'Energen', 5000,2),
		   (169, 'Kopi Lanang', 7000,2),
		   (170, 'Robusta Gunung Ijen', 5000,2);
		   
select * from kuliner