drop table tbl_ClockOut;
drop table tbl_ClockIn;

create table tbl_ClockOut (
	fld_id bigint,
	fld_firstName VARCHAR(50),
	fld_lastName VARCHAR(50),
	fld_personalIDnumber bigint,
    fld_deviceID VARCHAR(500),
	fld_latitube VARCHAR(50),
	fld_longitude VARCHAR(50),
	fld_dateTime DATE
);
insert into tbl_ClockOut (fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime) values (1, 'Klemens', 'Stonhouse',9605145124084, '00040000-00000000-00RRXXXX-XXZZZZZZ', -19.5189968, -42.628205, '2018-06-21 07:00:43');

create table tbl_ClockIn (
	fld_id bigint,
	fld_firstName VARCHAR(50),
	fld_lastName VARCHAR(50),
	fld_personalIDnumber bigint,
    fld_deviceID VARCHAR(500),
	fld_latitube VARCHAR(50),
	fld_longitude VARCHAR(50),
	fld_dateTime DATE
);
insert into tbl_ClockIn (fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime) values (1, 'Klemens', 'Stonhouse',9605145124084, '00040000-00000000-00RRXXXX-XXZZZZZZ', -19.5189968, -42.628205, '2018-06-21 07:00:43');
