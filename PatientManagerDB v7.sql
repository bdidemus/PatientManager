-- Dec 27 2011
-- Brett Didemus
-- Patient Manager DDL Script
-- v8

CREATE TABLE IF NOT EXISTS loginuser (
	usrName varchar(20),
	usrPassword char(32) NOT NULL,
	usrDateCreated timestamp DEFAULT NOW(),
	usrLastLogin timestamp,
	usrActive boolean DEFAULT true NOT NULL,
	CONSTRAINT pk_loginuser_usrname PRIMARY KEY(usrName));
	
CREATE TABLE IF NOT EXISTS reminder (
	remID integer AUTO_INCREMENT,
	remDateCreated timestamp DEFAULT NOW() NOT NULL,
	remTargetDate date NOT NULL,
	remNote	TEXT,
	remInterval integer,
	remActive boolean default true,
	CONSTRAINT pk_reminder_remid PRIMARY KEY(remID));
	
CREATE TABLE IF NOT EXISTS usr_reminder (
	usrName varchar(20),
	remID integer,
	CONSTRAINT pk_reminder_usrname_rmid PRIMARY KEY(usrName, remID));
	
CREATE TABLE IF NOT EXISTS country (
  iso CHAR(2) NOT NULL PRIMARY KEY,
  name VARCHAR(80) NOT NULL,
  printable_name VARCHAR(80) NOT NULL,
  iso3 CHAR(3),
  numcode SMALLINT
);
	
CREATE TABLE IF NOT EXISTS doc_type (
	docTypeID integer AUTO_INCREMENT,
	dtDec varchar(30) NOT NULL,
	CONSTRAINT pk_doc_type_doctypeid PRIMARY KEY(docTypeID));

	
CREATE TABLE IF NOT EXISTS doctor (
	docID integer AUTO_INCREMENT,
	docFirstName varchar(25) NOT NULL,
	docLastName varchar(30),
	docAddress varchar(75),
	docCity	varchar(30),
	iso CHAR(2),
	docPCode varchar(6),
	docOfficeNumber varchar(20),
	dovSecondaryNumber varchar(20),
	docMobileNumber varchar(20),
	docLicence varchar(20),
	docLicence2 varchar(20),
	docDateCreated timestamp DEFAULT NOW(),
	docDefaultColour char(7) DEFAULT "#0088ff",
	docTypeID integer,
	docActive boolean DEFAULT true,
	docDefault boolean DEFAULt false,
	CONSTRAINT pk_doctor_docid PRIMARY KEY(docID),
	CONSTRAINT fk_doctor_iso FOREIGN KEY(iso) REFERENCES country(iso),
	CONSTRAINT fk_doctor_typeid	FOREIGN KEY(docTypeID) REFERENCES doc_type(docTypeID));
	
CREATE TABLE IF NOT EXISTS patient (
	patID integer AUTO_INCREMENT,
	patFirstName varchar(20) NOT NULL,
	patLastName varchar(40) NOT NULL,
	patDateCreate timestamp DEFAULT NOW(),
	patSex		bit DEFAULT 0,
	patOHIP			char(10),
	patHealthCard char(10),
	patInsuranceNum varchar(15),
	patInsuranceProv	varchar(20),
	patAddress varchar(50),
	patAddress2 varchar(50),
	patPhoneNumber varchar(10),
	patMobileNumber varchar(10),
	patSecNumber	varchar(10),
	patPCode		char(6),
	patBirthday		date,
	patReferedBy varchar(50),
	patCity 	varchar(30),
	iso 			CHAR(2),
	patProv			varchar(4),
	patNotes		TEXT,
	patFlag			varchar(4),
	docID			integer,
	patActive		boolean DEFAULT true,
	CONSTRAINT pk_patient_patid PRIMARY KEY(patID),
	CONSTRAINT fk_patient_iso FOREIGN KEY(iso) REFERENCES country(iso),
	CONSTRAINT fk_patient_docid FOREIGN KEY(docID) REFERENCES doctor(docID));

CREATE TABLE IF NOT EXISTS payment_type (
	ptID integer AUTO_INCREMENT,
	ptName varchar(20),
	CONSTRAINT pk_payment_type_ptid PRIMARY KEY(ptID));

INSERT INTO payment_type VALUES(1, 'Cash');
INSERT INTO payment_type VALUES(2, 'Debit');
INSERT INTO payment_type VALUES(3, 'Visa');
INSERT INTO payment_type VALUES(4, 'Mastercard');
INSERT INTO payment_type VALUES(5, 'American Express');

CREATE TABLE IF NOT EXISTS payment (
	payID integer AUTO_INCREMENT,
	payAmount decimal(10, 2) NOT NULL,
	payDate timestamp DEFAULT NOW(),
	ptID integer NOT NULL,
	patID integer NOT NULL,
	payVoid boolean DEFAULT false,
	CONSTRAINT pk_payment_payid PRIMARY KEY(payID),
	CONSTRAINT fk_payment_ptid FOREIGN KEY(ptID) REFERENCES payment_type(ptID),
	CONSTRAINT fk_payment_patid FOREIGN KEY(patID) REFERENCES patient(patID));
	
CREATE TABLE IF NOT EXISTS appointment (
	appID integer AUTO_INCREMENT,
	appDate datetime NOT NULL,
	appDuration int NOT NULL,
	appNote TEXT,
	patID integer,
	docID integer,
	appDateCreate timestamp DEFAULT NOW(),
	appStatusID integer NOT NULL,
	appColour char(7),
	appAutoRenew boolean DEFAULT false,
	appRenewIntervalID integer DEFAULT 0,
	usrName varchar(20),
	CONSTRAINT pk_appointment_appid PRIMARY KEY(appID),
	CONSTRAINT fk_appointment_patid FOREIGN KEY(patID) REFERENCES patient(patID),
	CONSTRAINT fk_appointment_docid FOREIGN KEY(docID) REFERENCES doctor(docID),
	CONSTRAINT fk_appointment_usrname FOREIGN KEY(usrName) REFERENCES loginuser(usrName));
	
CREATE TABLE IF NOT EXISTS invoice (
	invID integer AUTO_INCREMENT,
	invDate timestamp DEFAULT NOW() NOT NULL,
	patID integer,
	invStatus integer DEFAULT 0,
	invCommitted boolean DEFAULT false,
	CONSTRAINT pk_invoice_invif PRIMARY KEY(invID),
	CONSTRAINT fk_invoice_patid FOREIGN KEY(patID) REFERENCES patient(patID));
	
CREATE TABLE IF NOT EXISTS category (
	catID integer AUTO_INCREMENT,
	catDesc varchar(30) NOT NULL,
	CONSTRAINT pk_category_catid PRIMARY KEY(catID));

CREATE TABLE IF NOT EXISTS inventory (
	itryID integer AUTO_INCREMENT,
	itryName varchar(30) NOT NULL,
	itryDesc varchar(50),
	itryCost decimal(10, 2),
	itryMarkup integer DEFAULT 0,
	itrySellingPrive decimal(10, 2),
	itryStock integer DEFAULT 0,
	itryActive boolean DEFAULT true,
	catID integer,
	CONSTRAINT pk_inventry_itryid PRIMARY KEY(itryID),
	CONSTRAINT fk_inventory_catid FOREIGN KEY(catID) REFERENCES category(catID));
	
CREATE TABLE IF NOT EXISTS  inv_line (
	invID integer,
	itryID integer,
	itryQty integer NOT NULL,
	linePrice decimal(10,2),
	CONSTRAINT pk_inv_line_invid_itryid PRIMARY KEY(invID, itryID),
	CONSTRAINT fk_inv_line_invid FOREIGN KEY(invID) REFERENCES invoice(invID),
	CONSTRAINT fk_inv_line_itryid FOREIGN KEY(itryID) REFERENCES inventory(itryID));
	
CREATE VIEW AccountingTotal AS
	SELECT Date( invDate ) AS 'date', SUM( linePrice * itryQty ) AS 'total', invoice.docID, 'Bill' AS
	TYPE FROM inv_line
	JOIN invoice ON ( inv_line.invID = invoice.invID )
	GROUP BY invoice.docID, Date( invDate )
	union
	SELECT Date(payDate) AS 'date', SUM(payAmount) AS 'total', payment.docID, 'payment' AS type FROM payment
	GROUP BY payment.docID, DATE(payDate);
	
INSERT INTO loginuser VALUES ('root', '63a9f0ea7bb98050796b649e85481845', null, null, true);

INSERT INTO country VALUES ('CA','CANADA','Canada','CAN','124');
INSERT INTO country VALUES ('US','UNITED STATES','United States','USA','840');
INSERT INTO country VALUES ('GB','UNITED KINGDOM','United Kingdom','GBR','826');
INSERT INTO country VALUES ('AF','AFGHANISTAN','Afghanistan','AFG','004');
INSERT INTO country VALUES ('AL','ALBANIA','Albania','ALB','008');
INSERT INTO country VALUES ('DZ','ALGERIA','Algeria','DZA','012');
INSERT INTO country VALUES ('AS','AMERICAN SAMOA','American Samoa','ASM','016');
INSERT INTO country VALUES ('AD','ANDORRA','Andorra','AND','020');
INSERT INTO country VALUES ('AO','ANGOLA','Angola','AGO','024');
INSERT INTO country VALUES ('AI','ANGUILLA','Anguilla','AIA','660');
INSERT INTO country VALUES ('AQ','ANTARCTICA','Antarctica',NULL,NULL);
INSERT INTO country VALUES ('AG','ANTIGUA AND BARBUDA','Antigua and Barbuda','ATG','028');
INSERT INTO country VALUES ('AR','ARGENTINA','Argentina','ARG','032');
INSERT INTO country VALUES ('AM','ARMENIA','Armenia','ARM','051');
INSERT INTO country VALUES ('AW','ARUBA','Aruba','ABW','533');
INSERT INTO country VALUES ('AU','AUSTRALIA','Australia','AUS','036');
INSERT INTO country VALUES ('AT','AUSTRIA','Austria','AUT','040');
INSERT INTO country VALUES ('AZ','AZERBAIJAN','Azerbaijan','AZE','031');
INSERT INTO country VALUES ('BS','BAHAMAS','Bahamas','BHS','044');
INSERT INTO country VALUES ('BH','BAHRAIN','Bahrain','BHR','048');
INSERT INTO country VALUES ('BD','BANGLADESH','Bangladesh','BGD','050');
INSERT INTO country VALUES ('BB','BARBADOS','Barbados','BRB','052');
INSERT INTO country VALUES ('BY','BELARUS','Belarus','BLR','112');
INSERT INTO country VALUES ('BE','BELGIUM','Belgium','BEL','056');
INSERT INTO country VALUES ('BZ','BELIZE','Belize','BLZ','084');
INSERT INTO country VALUES ('BJ','BENIN','Benin','BEN','204');
INSERT INTO country VALUES ('BM','BERMUDA','Bermuda','BMU','060');
INSERT INTO country VALUES ('BT','BHUTAN','Bhutan','BTN','064');
INSERT INTO country VALUES ('BO','BOLIVIA','Bolivia','BOL','068');
INSERT INTO country VALUES ('BA','BOSNIA AND HERZEGOVINA','Bosnia and Herzegovina','BIH','070');
INSERT INTO country VALUES ('BW','BOTSWANA','Botswana','BWA','072');
INSERT INTO country VALUES ('BV','BOUVET ISLAND','Bouvet Island',NULL,NULL);
INSERT INTO country VALUES ('BR','BRAZIL','Brazil','BRA','076');
INSERT INTO country VALUES ('IO','BRITISH INDIAN OCEAN TERRITORY','British Indian Ocean Territory',NULL,NULL);
INSERT INTO country VALUES ('BN','BRUNEI DARUSSALAM','Brunei Darussalam','BRN','096');
INSERT INTO country VALUES ('BG','BULGARIA','Bulgaria','BGR','100');
INSERT INTO country VALUES ('BF','BURKINA FASO','Burkina Faso','BFA','854');
INSERT INTO country VALUES ('BI','BURUNDI','Burundi','BDI','108');
INSERT INTO country VALUES ('KH','CAMBODIA','Cambodia','KHM','116');
INSERT INTO country VALUES ('CM','CAMEROON','Cameroon','CMR','120');
INSERT INTO country VALUES ('CV','CAPE VERDE','Cape Verde','CPV','132');
INSERT INTO country VALUES ('KY','CAYMAN ISLANDS','Cayman Islands','CYM','136');
INSERT INTO country VALUES ('CF','CENTRAL AFRICAN REPUBLIC','Central African Republic','CAF','140');
INSERT INTO country VALUES ('TD','CHAD','Chad','TCD','148');
INSERT INTO country VALUES ('CL','CHILE','Chile','CHL','152');
INSERT INTO country VALUES ('CN','CHINA','China','CHN','156');
INSERT INTO country VALUES ('CX','CHRISTMAS ISLAND','Christmas Island',NULL,NULL);
INSERT INTO country VALUES ('CC','COCOS (KEELING) ISLANDS','Cocos (Keeling) Islands',NULL,NULL);
INSERT INTO country VALUES ('CO','COLOMBIA','Colombia','COL','170');
INSERT INTO country VALUES ('KM','COMOROS','Comoros','COM','174');
INSERT INTO country VALUES ('CG','CONGO','Congo','COG','178');
INSERT INTO country VALUES ('CD','CONGO, THE DEMOCRATIC REPUBLIC OF THE','Congo, the Democratic Republic of the','COD','180');
INSERT INTO country VALUES ('CK','COOK ISLANDS','Cook Islands','COK','184');
INSERT INTO country VALUES ('CR','COSTA RICA','Costa Rica','CRI','188');
INSERT INTO country VALUES ('CI','COTE D\'IVOIRE','Cote D\'Ivoire','CIV','384');
INSERT INTO country VALUES ('HR','CROATIA','Croatia','HRV','191');
INSERT INTO country VALUES ('CU','CUBA','Cuba','CUB','192');
INSERT INTO country VALUES ('CY','CYPRUS','Cyprus','CYP','196');
INSERT INTO country VALUES ('CZ','CZECH REPUBLIC','Czech Republic','CZE','203');
INSERT INTO country VALUES ('DK','DENMARK','Denmark','DNK','208');
INSERT INTO country VALUES ('DJ','DJIBOUTI','Djibouti','DJI','262');
INSERT INTO country VALUES ('DM','DOMINICA','Dominica','DMA','212');
INSERT INTO country VALUES ('DO','DOMINICAN REPUBLIC','Dominican Republic','DOM','214');
INSERT INTO country VALUES ('EC','ECUADOR','Ecuador','ECU','218');
INSERT INTO country VALUES ('EG','EGYPT','Egypt','EGY','818');
INSERT INTO country VALUES ('SV','EL SALVADOR','El Salvador','SLV','222');
INSERT INTO country VALUES ('GQ','EQUATORIAL GUINEA','Equatorial Guinea','GNQ','226');
INSERT INTO country VALUES ('ER','ERITREA','Eritrea','ERI','232');
INSERT INTO country VALUES ('EE','ESTONIA','Estonia','EST','233');
INSERT INTO country VALUES ('ET','ETHIOPIA','Ethiopia','ETH','231');
INSERT INTO country VALUES ('FK','FALKLAND ISLANDS (MALVINAS)','Falkland Islands (Malvinas)','FLK','238');
INSERT INTO country VALUES ('FO','FAROE ISLANDS','Faroe Islands','FRO','234');
INSERT INTO country VALUES ('FJ','FIJI','Fiji','FJI','242');
INSERT INTO country VALUES ('FI','FINLAND','Finland','FIN','246');
INSERT INTO country VALUES ('FR','FRANCE','France','FRA','250');
INSERT INTO country VALUES ('GF','FRENCH GUIANA','French Guiana','GUF','254');
INSERT INTO country VALUES ('PF','FRENCH POLYNESIA','French Polynesia','PYF','258');
INSERT INTO country VALUES ('TF','FRENCH SOUTHERN TERRITORIES','French Southern Territories',NULL,NULL);
INSERT INTO country VALUES ('GA','GABON','Gabon','GAB','266');
INSERT INTO country VALUES ('GM','GAMBIA','Gambia','GMB','270');
INSERT INTO country VALUES ('GE','GEORGIA','Georgia','GEO','268');
INSERT INTO country VALUES ('DE','GERMANY','Germany','DEU','276');
INSERT INTO country VALUES ('GH','GHANA','Ghana','GHA','288');
INSERT INTO country VALUES ('GI','GIBRALTAR','Gibraltar','GIB','292');
INSERT INTO country VALUES ('GR','GREECE','Greece','GRC','300');
INSERT INTO country VALUES ('GL','GREENLAND','Greenland','GRL','304');
INSERT INTO country VALUES ('GD','GRENADA','Grenada','GRD','308');
INSERT INTO country VALUES ('GP','GUADELOUPE','Guadeloupe','GLP','312');
INSERT INTO country VALUES ('GU','GUAM','Guam','GUM','316');
INSERT INTO country VALUES ('GT','GUATEMALA','Guatemala','GTM','320');
INSERT INTO country VALUES ('GN','GUINEA','Guinea','GIN','324');
INSERT INTO country VALUES ('GW','GUINEA-BISSAU','Guinea-Bissau','GNB','624');
INSERT INTO country VALUES ('GY','GUYANA','Guyana','GUY','328');
INSERT INTO country VALUES ('HT','HAITI','Haiti','HTI','332');
INSERT INTO country VALUES ('HM','HEARD ISLAND AND MCDONALD ISLANDS','Heard Island and Mcdonald Islands',NULL,NULL);
INSERT INTO country VALUES ('VA','HOLY SEE (VATICAN CITY STATE)','Holy See (Vatican City State)','VAT','336');
INSERT INTO country VALUES ('HN','HONDURAS','Honduras','HND','340');
INSERT INTO country VALUES ('HK','HONG KONG','Hong Kong','HKG','344');
INSERT INTO country VALUES ('HU','HUNGARY','Hungary','HUN','348');
INSERT INTO country VALUES ('IS','ICELAND','Iceland','ISL','352');
INSERT INTO country VALUES ('IN','INDIA','India','IND','356');
INSERT INTO country VALUES ('ID','INDONESIA','Indonesia','IDN','360');
INSERT INTO country VALUES ('IR','IRAN, ISLAMIC REPUBLIC OF','Iran, Islamic Republic of','IRN','364');
INSERT INTO country VALUES ('IQ','IRAQ','Iraq','IRQ','368');
INSERT INTO country VALUES ('IE','IRELAND','Ireland','IRL','372');
INSERT INTO country VALUES ('IL','ISRAEL','Israel','ISR','376');
INSERT INTO country VALUES ('IT','ITALY','Italy','ITA','380');
INSERT INTO country VALUES ('JM','JAMAICA','Jamaica','JAM','388');
INSERT INTO country VALUES ('JP','JAPAN','Japan','JPN','392');
INSERT INTO country VALUES ('JO','JORDAN','Jordan','JOR','400');
INSERT INTO country VALUES ('KZ','KAZAKHSTAN','Kazakhstan','KAZ','398');
INSERT INTO country VALUES ('KE','KENYA','Kenya','KEN','404');
INSERT INTO country VALUES ('KI','KIRIBATI','Kiribati','KIR','296');
INSERT INTO country VALUES ('KP','KOREA, DEMOCRATIC PEOPLE\'S REPUBLIC OF','Korea, Democratic People\'s Republic of','PRK','408');
INSERT INTO country VALUES ('KR','KOREA, REPUBLIC OF','Korea, Republic of','KOR','410');
INSERT INTO country VALUES ('KW','KUWAIT','Kuwait','KWT','414');
INSERT INTO country VALUES ('KG','KYRGYZSTAN','Kyrgyzstan','KGZ','417');
INSERT INTO country VALUES ('LA','LAO PEOPLE\'S DEMOCRATIC REPUBLIC','Lao People\'s Democratic Republic','LAO','418');
INSERT INTO country VALUES ('LV','LATVIA','Latvia','LVA','428');
INSERT INTO country VALUES ('LB','LEBANON','Lebanon','LBN','422');
INSERT INTO country VALUES ('LS','LESOTHO','Lesotho','LSO','426');
INSERT INTO country VALUES ('LR','LIBERIA','Liberia','LBR','430');
INSERT INTO country VALUES ('LY','LIBYAN ARAB JAMAHIRIYA','Libyan Arab Jamahiriya','LBY','434');
INSERT INTO country VALUES ('LI','LIECHTENSTEIN','Liechtenstein','LIE','438');
INSERT INTO country VALUES ('LT','LITHUANIA','Lithuania','LTU','440');
INSERT INTO country VALUES ('LU','LUXEMBOURG','Luxembourg','LUX','442');
INSERT INTO country VALUES ('MO','MACAO','Macao','MAC','446');
INSERT INTO country VALUES ('MK','MACEDONIA, THE FORMER YUGOSLAV REPUBLIC OF','Macedonia, the Former Yugoslav Republic of','MKD','807');
INSERT INTO country VALUES ('MG','MADAGASCAR','Madagascar','MDG','450');
INSERT INTO country VALUES ('MW','MALAWI','Malawi','MWI','454');
INSERT INTO country VALUES ('MY','MALAYSIA','Malaysia','MYS','458');
INSERT INTO country VALUES ('MV','MALDIVES','Maldives','MDV','462');
INSERT INTO country VALUES ('ML','MALI','Mali','MLI','466');
INSERT INTO country VALUES ('MT','MALTA','Malta','MLT','470');
INSERT INTO country VALUES ('MH','MARSHALL ISLANDS','Marshall Islands','MHL','584');
INSERT INTO country VALUES ('MQ','MARTINIQUE','Martinique','MTQ','474');
INSERT INTO country VALUES ('MR','MAURITANIA','Mauritania','MRT','478');
INSERT INTO country VALUES ('MU','MAURITIUS','Mauritius','MUS','480');
INSERT INTO country VALUES ('YT','MAYOTTE','Mayotte',NULL,NULL);
INSERT INTO country VALUES ('MX','MEXICO','Mexico','MEX','484');
INSERT INTO country VALUES ('FM','MICRONESIA, FEDERATED STATES OF','Micronesia, Federated States of','FSM','583');
INSERT INTO country VALUES ('MD','MOLDOVA, REPUBLIC OF','Moldova, Republic of','MDA','498');
INSERT INTO country VALUES ('MC','MONACO','Monaco','MCO','492');
INSERT INTO country VALUES ('MN','MONGOLIA','Mongolia','MNG','496');
INSERT INTO country VALUES ('MS','MONTSERRAT','Montserrat','MSR','500');
INSERT INTO country VALUES ('MA','MOROCCO','Morocco','MAR','504');
INSERT INTO country VALUES ('MZ','MOZAMBIQUE','Mozambique','MOZ','508');
INSERT INTO country VALUES ('MM','MYANMAR','Myanmar','MMR','104');
INSERT INTO country VALUES ('NA','NAMIBIA','Namibia','NAM','516');
INSERT INTO country VALUES ('NR','NAURU','Nauru','NRU','520');
INSERT INTO country VALUES ('NP','NEPAL','Nepal','NPL','524');
INSERT INTO country VALUES ('NL','NETHERLANDS','Netherlands','NLD','528');
INSERT INTO country VALUES ('AN','NETHERLANDS ANTILLES','Netherlands Antilles','ANT','530');
INSERT INTO country VALUES ('NC','NEW CALEDONIA','New Caledonia','NCL','540');
INSERT INTO country VALUES ('NZ','NEW ZEALAND','New Zealand','NZL','554');
INSERT INTO country VALUES ('NI','NICARAGUA','Nicaragua','NIC','558');
INSERT INTO country VALUES ('NE','NIGER','Niger','NER','562');
INSERT INTO country VALUES ('NG','NIGERIA','Nigeria','NGA','566');
INSERT INTO country VALUES ('NU','NIUE','Niue','NIU','570');
INSERT INTO country VALUES ('NF','NORFOLK ISLAND','Norfolk Island','NFK','574');
INSERT INTO country VALUES ('MP','NORTHERN MARIANA ISLANDS','Northern Mariana Islands','MNP','580');
INSERT INTO country VALUES ('NO','NORWAY','Norway','NOR','578');
INSERT INTO country VALUES ('OM','OMAN','Oman','OMN','512');
INSERT INTO country VALUES ('PK','PAKISTAN','Pakistan','PAK','586');
INSERT INTO country VALUES ('PW','PALAU','Palau','PLW','585');
INSERT INTO country VALUES ('PS','PALESTINIAN TERRITORY, OCCUPIED','Palestinian Territory, Occupied',NULL,NULL);
INSERT INTO country VALUES ('PA','PANAMA','Panama','PAN','591');
INSERT INTO country VALUES ('PG','PAPUA NEW GUINEA','Papua New Guinea','PNG','598');
INSERT INTO country VALUES ('PY','PARAGUAY','Paraguay','PRY','600');
INSERT INTO country VALUES ('PE','PERU','Peru','PER','604');
INSERT INTO country VALUES ('PH','PHILIPPINES','Philippines','PHL','608');
INSERT INTO country VALUES ('PN','PITCAIRN','Pitcairn','PCN','612');
INSERT INTO country VALUES ('PL','POLAND','Poland','POL','616');
INSERT INTO country VALUES ('PT','PORTUGAL','Portugal','PRT','620');
INSERT INTO country VALUES ('PR','PUERTO RICO','Puerto Rico','PRI','630');
INSERT INTO country VALUES ('QA','QATAR','Qatar','QAT','634');
INSERT INTO country VALUES ('RE','REUNION','Reunion','REU','638');
INSERT INTO country VALUES ('RO','ROMANIA','Romania','ROM','642');
INSERT INTO country VALUES ('RU','RUSSIAN FEDERATION','Russian Federation','RUS','643');
INSERT INTO country VALUES ('RW','RWANDA','Rwanda','RWA','646');
INSERT INTO country VALUES ('SH','SAINT HELENA','Saint Helena','SHN','654');
INSERT INTO country VALUES ('KN','SAINT KITTS AND NEVIS','Saint Kitts and Nevis','KNA','659');
INSERT INTO country VALUES ('LC','SAINT LUCIA','Saint Lucia','LCA','662');
INSERT INTO country VALUES ('PM','SAINT PIERRE AND MIQUELON','Saint Pierre and Miquelon','SPM','666');
INSERT INTO country VALUES ('VC','SAINT VINCENT AND THE GRENADINES','Saint Vincent and the Grenadines','VCT','670');
INSERT INTO country VALUES ('WS','SAMOA','Samoa','WSM','882');
INSERT INTO country VALUES ('SM','SAN MARINO','San Marino','SMR','674');
INSERT INTO country VALUES ('ST','SAO TOME AND PRINCIPE','Sao Tome and Principe','STP','678');
INSERT INTO country VALUES ('SA','SAUDI ARABIA','Saudi Arabia','SAU','682');
INSERT INTO country VALUES ('SN','SENEGAL','Senegal','SEN','686');
INSERT INTO country VALUES ('CS','SERBIA AND MONTENEGRO','Serbia and Montenegro',NULL,NULL);
INSERT INTO country VALUES ('SC','SEYCHELLES','Seychelles','SYC','690');
INSERT INTO country VALUES ('SL','SIERRA LEONE','Sierra Leone','SLE','694');
INSERT INTO country VALUES ('SG','SINGAPORE','Singapore','SGP','702');
INSERT INTO country VALUES ('SK','SLOVAKIA','Slovakia','SVK','703');
INSERT INTO country VALUES ('SI','SLOVENIA','Slovenia','SVN','705');
INSERT INTO country VALUES ('SB','SOLOMON ISLANDS','Solomon Islands','SLB','090');
INSERT INTO country VALUES ('SO','SOMALIA','Somalia','SOM','706');
INSERT INTO country VALUES ('ZA','SOUTH AFRICA','South Africa','ZAF','710');
INSERT INTO country VALUES ('GS','SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS','South Georgia and the South Sandwich Islands',NULL,NULL);
INSERT INTO country VALUES ('ES','SPAIN','Spain','ESP','724');
INSERT INTO country VALUES ('LK','SRI LANKA','Sri Lanka','LKA','144');
INSERT INTO country VALUES ('SD','SUDAN','Sudan','SDN','736');
INSERT INTO country VALUES ('SR','SURINAME','Suriname','SUR','740');
INSERT INTO country VALUES ('SJ','SVALBARD AND JAN MAYEN','Svalbard and Jan Mayen','SJM','744');
INSERT INTO country VALUES ('SZ','SWAZILAND','Swaziland','SWZ','748');
INSERT INTO country VALUES ('SE','SWEDEN','Sweden','SWE','752');
INSERT INTO country VALUES ('CH','SWITZERLAND','Switzerland','CHE','756');
INSERT INTO country VALUES ('SY','SYRIAN ARAB REPUBLIC','Syrian Arab Republic','SYR','760');
INSERT INTO country VALUES ('TW','TAIWAN, PROVINCE OF CHINA','Taiwan, Province of China','TWN','158');
INSERT INTO country VALUES ('TJ','TAJIKISTAN','Tajikistan','TJK','762');
INSERT INTO country VALUES ('TZ','TANZANIA, UNITED REPUBLIC OF','Tanzania, United Republic of','TZA','834');
INSERT INTO country VALUES ('TH','THAILAND','Thailand','THA','764');
INSERT INTO country VALUES ('TL','TIMOR-LESTE','Timor-Leste',NULL,NULL);
INSERT INTO country VALUES ('TG','TOGO','Togo','TGO','768');
INSERT INTO country VALUES ('TK','TOKELAU','Tokelau','TKL','772');
INSERT INTO country VALUES ('TO','TONGA','Tonga','TON','776');
INSERT INTO country VALUES ('TT','TRINIDAD AND TOBAGO','Trinidad and Tobago','TTO','780');
INSERT INTO country VALUES ('TN','TUNISIA','Tunisia','TUN','788');
INSERT INTO country VALUES ('TR','TURKEY','Turkey','TUR','792');
INSERT INTO country VALUES ('TM','TURKMENISTAN','Turkmenistan','TKM','795');
INSERT INTO country VALUES ('TC','TURKS AND CAICOS ISLANDS','Turks and Caicos Islands','TCA','796');
INSERT INTO country VALUES ('TV','TUVALU','Tuvalu','TUV','798');
INSERT INTO country VALUES ('UG','UGANDA','Uganda','UGA','800');
INSERT INTO country VALUES ('UA','UKRAINE','Ukraine','UKR','804');
INSERT INTO country VALUES ('AE','UNITED ARAB EMIRATES','United Arab Emirates','ARE','784');
INSERT INTO country VALUES ('UM','UNITED STATES MINOR OUTLYING ISLANDS','United States Minor Outlying Islands',NULL,NULL);
INSERT INTO country VALUES ('UY','URUGUAY','Uruguay','URY','858');
INSERT INTO country VALUES ('UZ','UZBEKISTAN','Uzbekistan','UZB','860');
INSERT INTO country VALUES ('VU','VANUATU','Vanuatu','VUT','548');
INSERT INTO country VALUES ('VE','VENEZUELA','Venezuela','VEN','862');
INSERT INTO country VALUES ('VN','VIET NAM','Viet Nam','VNM','704');
INSERT INTO country VALUES ('VG','VIRGIN ISLANDS, BRITISH','Virgin Islands, British','VGB','092');
INSERT INTO country VALUES ('VI','VIRGIN ISLANDS, U.S.','Virgin Islands, U.s.','VIR','850');
INSERT INTO country VALUES ('WF','WALLIS AND FUTUNA','Wallis and Futuna','WLF','876');
INSERT INTO country VALUES ('EH','WESTERN SAHARA','Western Sahara','ESH','732');
INSERT INTO country VALUES ('YE','YEMEN','Yemen','YEM','887');
INSERT INTO country VALUES ('ZM','ZAMBIA','Zambia','ZMB','894');
INSERT INTO country VALUES ('ZW','ZIMBABWE','Zimbabwe','ZWE','716');

INSERT INTO doc_type VALUES(DEFAULT, 'Chiropractic');	
INSERT INTO doc_type VALUES (null, 'General');

ALTER TABLE doctor MODIFY docLastName varchar(30);
ALTER TABLE doctor MODIFY docDefaultColour char(7) DEFAULT "#0088ff";

INSERT INTO doctor (docID, docFirstName, docTypeID, docDefaultColour) VALUES(1, "Clinic", 2, "#4682b4");

INSERT INTO category VALUES(1, "Appointments");

INSERT INTO inventory VALUES(1, 'Appointment Fee', null, 50, 0, 50, 1, true, 1);
INSERT INTO inventory VALUES(2, 'Carryover Balance', "Balance from old program", 0, 0, 0, 1, true, null);

-- Add default value to invoice
ALTER TABLE invoice MODIFY invStatus integer DEFAULT 0;

-- Add inventory row to appointments
ALTER TABLE appointment ADD itryID int;
ALTER TABLE appointment ADD CONSTRAINT FOREIGN KEY(itryID) REFERENCES inventory(itryID);

-- Add doctors to payments and invoices
ALTER TABLE payment ADD docID int NOT NULL;
ALTER TABLE payment ADD CONSTRAINT fk_payment_docid FOREIGN KEY(docID) REFERENCES doctor(docID);

ALTER TABLE invoice ADD docID int NOT NULL;
ALTER TABLE invoice ADD CONSTRAINT fk_invoice_docid FOREIGN KEY(docID) REFERENCES doctor(docID);

ALTER TABLE patient MODIFY docID integer NOT NULL DEFAULT 1;
	
-- Modified v8 -- added line_discount
CREATE VIEW PatientAccountHistoryView AS
SELECT DATE(invDate) as 'Date', patID, itryName AS 'Type', itryDesc AS 'Description', itryQty, linePrice AS 'Amount', line_discount, docID FROM inv_line
INNER JOIN invoice ON (invoice.invID = inv_line.invID)
INNER JOIN inventory ON (inventory.itryID = inv_line.itryID)
UNION ALL
SELECT DATE(payDate), patID, 'Payment', ptName, null, payAmount, 0, docID  FROM payment
INNER JOIN payment_type ON (payment.ptID = payment_type.ptID)

-- Added version 6
ALTER TABLE payment ADD invID int DEFAULT NULL;
ALTER TABLE payment ADD CONSTRAINT FOREIGN KEY(invID) REFERENCES invoice(invID);

-- Added version 7
ALTER TABLE doctor ADD docLicence2 varchar(20) DEFAULT NULL AFTER docLicence;

-- Added version 8 to allow discounts on bills
ALTER TABLE inv_line ADD line_discount decimal(5, 2) DEFAULT 0 NOT NULL AFTER linePrice; 