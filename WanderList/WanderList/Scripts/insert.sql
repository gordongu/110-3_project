USE Wanderlist;

IF NOT EXISTS (SELECT * FROM [Wanderlist.Location])
BEGIN
    INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description) 
	VALUES(1, 'Press Play Bar Boulder', '1005 Pearl St Boulder CO 80302', 4, 'Bar with a lot of arcade games');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(2, 'The Walrus', '1911 11th St Boulder CO 80302', 4, 'Bar to Dance at');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(3, 'Sundown Saloon', '1136 Pearl St Boulder CO 80302', 3, 'Bar to Play Pool at');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(4, 'The Sink', '1165 13th St Boulder CO 80302', 3, 'Bar on the Hill');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(5, 'The Bitter Bar', '835 Walnut St Boulder CO 80302', 5, 'Coctail Bar');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(6, 'Bohemian Biergarten', '2017 13th St Boulder CO 80302', 4, 'Czech-style Bar with pretzals and karaoke on Wednesday');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(7, 'The Attic Bar and Bistro', '949 Walnut St Boulder CO 80302', 5, 'Cozy bar with games and live performance');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(8, 'Dark Horse', '2922 Baseline Rd Boulder CO 80303', 3, 'Burgers and games');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(9, 'The Taj - Boulder', '2630 Baseline Rd Boulder CO 80305', 4, 'Indian Cuisine');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(10, 'The Buff Restaurant', '2600 Canyon Blvd Boulder CO 80302', 4, 'American Food');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(11, 'Beau Jos Boulder', '2690 Baseline Rd Boulder CO 80305', 4, 'PIzza');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(12, 'Terra Thai', '1121 Broadway #103 Boulder CO 80303', 4, 'Thai food');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(13, 'The Kitchen', '1039 Pearl St Boulder CO 80302', 4, 'American Food');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(14, 'Rincon Argentino', '2525 Arapahoe Ave Boulder CO 80302', 5, 'Argentinean Food');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(15, 'Brasserie Ten Ten', '1011 Walnut St Boulder CO 80302', 4, 'Homestyle French food');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(16, 'The Mediterranean Restaurant', '1002 Walnut St Boulder CO 80302', 4, 'Greek island-themed eatery');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(17, 'Blackbelly Market', '1606 Conestoga St #3 Boulder CO 80301', 4, 'Farmhouse-chic eatery');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(18, 'Snooze An AM Eatery', '1617 Pearl St Boulder CO 80302', 5, 'Breakfast food');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(19, 'Pearl Street Mall', '1942 Broadway #301 Boulder CO 80302', 5, 'Outdoor outlet mall with lots of unqiue specialty stores');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(20, 'Flatiron Crossing', '1 W Flatiron Crossing Dr Broomfield CO 80021', 4, 'Indoor and outdoor mall');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(21, 'The Village Shopping Center', '2525 Arapahoe Ave C220 Boulder CO 80302', 4, 'Spraling outdoor outlet mall with lots of local businesses');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(22, 'Twenty Ninth Street Mall', '1710 29th St Boulder CO 80301', 4, 'Urban outdoor mall outlets with high end businesses');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(23, 'Base-Mar Shopping Center', '2450 Baseline Rd Boulder CO 80305', 2, 'Small shopping center with several restaurants');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(24, 'Boulder Book Store', '1107 Pearl St Boulder CO 80302', 5, 'Book Store');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(25, 'Gateway Park Fun Center', '4800 28th St Boulder CO 80301', 4, 'Mini-golf');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(26, 'Century Theaters Boulder', '1700 29th St Boulder CO 80301', 4, 'Movie Theatre');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(27, 'Celestial Seasonings Tour', '4600 Sleepytime Dr Boulder CO 80301', 5, 'Tea and Guided Tour');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(28, 'Boulder Theater', '2032 14th St Boulder CO 80302', 5, 'Concert Theater');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(29, 'Boulder Dinner Theater', '5501 Arapahoe Ave Boulder CO 80303', 5, 'Dinner Theater');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(30, 'Flatirons Golf Course', '5706 Arapahoe Ave Boulder CO 80303', 4, 'Golf Course');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(31, 'Enigma Escape Rooms', '1426 Pearl St #020 Boulder CO 80302', 5, 'Escape Rooms');

	INSERT INTO [Wanderlist.Location](location_id, name, address, rating, description)
	VALUES(32, 'Boulder Symphony', '1820 15th St Boulder CO 80302', 4, 'Concert Hall');
END