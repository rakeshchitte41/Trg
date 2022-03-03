);
CREATE TABLE blooddaonation.Hospitals(
			Id int ,
            area varchar(50) not null,
            hospital_name varchar(50) not null,
            pincode int not null,
            state varchar(50) not null,
            city varchar(50) not null,
            phone_number int not null
);
CREATE TABLE blooddaonation.Camps(
			Id int ,
            area varchar(50) not null,
            camp_name varchar(50) not null,
            pincode int not null,
            state varchar(50) not null,
            city varchar(50) not null,
            phone_number int not null
);

CREATE TABLE blooddaonation.Blood_banks(
			Id int ,
            area varchar(50) not null,
            hospital_name varchar(50) not null,
            pincode int not null,
            state varchar(50) not null,
            city varchar(50) not null,
            phone_number int not null
);
CREATE TABLE blooddaonation.Donors(
			Id int ,
            firstname varchar(50) not null,
            lastname varchar(50) not null,
            bloodgroup varchar(50)not null,
            phone_number int not null,
            area varchar(50)not null,
            city varchar(50) not null,
            state varchar(50) not null,
            pincode int,
            FOREIGN KEY (firtsname) REFERENCES Persons(fristname),
            FOREIGN KEY (lastname) REFERENCES Persons(fristname),
            FOREIGN KEY (phone_number) REFERENCES Persons(fristname),
            FOREIGN KEY (area) REFERENCES Persons(fristname),
            FOREIGN KEY (city) REFERENCES Persons(fristname),
            FOREIGN KEY (state) REFERENCES Persons(fristname)
);
CREATE TABLE blooddaonation.Users(
			Id int ,
            email varchar(50) not null,
            password varchar(50)not null,
            firstname varchar(50)not null,
            lastname int not null,
            date_of_birth date,
            phone_number varchar(50) not null,
            area varchar(50) not null,
            city varchar(50) not null,
            pincode int not null,
            primary key(email)
            
);