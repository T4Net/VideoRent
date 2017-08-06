CREATE DATABASE video_db;
USE sakila;
SHOW Tables FROM video_db; 
SELECT * FROM video_db.movie_copies;
SET GLOBAL event_scheduler = ON;
SET GLOBAL event_scheduler = OFF;
ALTER TABLE members AUTO_INCREMENT=108;
SHOW EVENTS;
-- SAFE MODE means that you can't update or delete records without specifying a key (ex. primary key)
SET SQL_SAFE_UPDATES = 0;
SET SQL_SAFE_UPDATES = 0;
-- Set new delimiter '|'
DELIMITER | 
CREATE EVENT UpdateCategory
    ON SCHEDULE
	EVERY 24 HOUR
	DO
    BEGIN		
        UPDATE category_tb
        SET category= IF(DATEDIFF(Now(), dateAdded) > 90 AND DATEDIFF(Now(), dateAdded) < 180,
			'Medium', IF(DATEDIFF(Now(), dateAdded) > 180, 'Low', category));
	END |
DELIMITER ;
 -- Set default delimiter ';'
SELECT 'condition'
    FROM movie_copies
	INNER JOIN movies ON movie_copies.movieID = movies.movieID;
    WHERE movie_copies.movieID  = movies.movieID;
DELIMITER | 
CREATE EVENT UpdateCategory2
    ON SCHEDULE
	EVERY 24 HOUR
	DO
	BEGIN
    DECLARE noOfVideos INT;
	SELECT COUNT(copyID)
    FROM rentals
    WHERE DATE(rentals.rentalTime) < ADDDATE(NOW(), INTERVAL 30 DAY) -- DATE_ADD(NOW(), INTERVAL 2 DAY);
    AND returnDate IS NULL;
    SELECT noOfVideos;
    CALL test_procedure;
    END;
		IF NOW() <= (category_tb.dateAdded + 90) THEN
			UPDATE category_tb
			SET category= 'Hot';
		ELSEIF  NOW() <= (category_tb.dateAdded + 180) THEN
			UPDATE category_tb
			SET category= 'Medium';
		ELSE
			UPDATE category_tb
			SET category= 'Low';
		END IF;
    END |
    CALL test_procedure;
DELIMITER ;
DROP EVENT TestUpdateCategory2;
CALL test;
SELECT DATEDIFF(rentalTime, rentalDate) FROM rentals WHERE rentId = 2;

DELIMITER |
CREATE EVENT TestUpdateCategory
    ON SCHEDULE
	EVERY 10 SECOND
	DO
    BEGIN		
        UPDATE category_tb
        SET category= IF(dateAdded + INTERVAL 60 SECOND > Now()
			AND category= 'Hot', 'Medium', IF(dateAdded + INTERVAL 60 SECOND > Now()
            AND category= 'Medium', 'Hot', category));
	END |
DELIMITER ;

DELIMITER |
CREATE EVENT TestUpdateCategory2
    ON SCHEDULE
	EVERY 10 SECOND
	DO
    BEGIN		
		-- SELECT  TIME_TO_SEC(TIMEDIFF(Now(), dateAdded)) AS timeInt;
        UPDATE category_tb
        SET category= IF(TIME_TO_SEC(TIMEDIFF(Now(), dateAdded)) > 20 AND TIME_TO_SEC(TIMEDIFF(Now(), dateAdded)) < 60,
			'Medium', IF(TIME_TO_SEC(TIMEDIFF(Now(), dateAdded)) > 60, 'Low', category));
	END |
DELIMITER ;

UPDATE category_tb
        SET category= 'Medium'
        WHERE dateAdded < Now() + INTERVAL 60 SECOND
        AND category= 'Low';
        UPDATE category_tb
        SET category= 'Hot'
        WHERE dateAdded < Now() + INTERVAL 60 SECOND
        AND category= 'Medium';
USE video_db; 
INSERT INTO category_tb (category, movieID)
VALUES ('Hot', );
DELETE FROM `video_db`.`category_tb` WHERE `category`='Medium';

SELECT * FROM video_db.cover_images;
USE video_db;
ALTER TABLE video_db.cover_images
ADD movieID INT(11),
ADD FOREIGN KEY (movieID) REFERENCES movies(movieID);
SET SQL_SAFE_UPDATES = 0;
USE video_db;
UPDATE cover_images
INNER JOIN movies ON cover_images.title = movies.title
SET cover_images.movieID = movies.movieID
WHERE cover_images.title = movies.title;
SET SQL_SAFE_UPDATES = 1;

SELECT * FROM video_db.rate;
INSERT INTO rate (Hot)
VALUES ((SELECT movieID FROM movies WHERE category = 'Hot'));

SELECT * FROM video_db.renting_cost;
SET SQL_SAFE_UPDATES = 0;
USE video_db; 
INSERT INTO renting_cost (Hot, Medium, Low)
VALUES (21, 16, 11);
SET SQL_SAFE_UPDATES = 1;
ALTER TABLE renting_cost AUTO_INCREMENT = 2;

SELECT * FROM video_db.movies;
USE video_db; 
INSERT INTO movies (title, year, language, country, oscar, genre)
VALUES ('Arami', 2014, 'Japanish', 'Japan', 'No', 'Comedy');
SET SQL_SAFE_UPDATES = 0;
UPDATE movies
SET category = 'Hot'
WHERE movieID <=23;

SELECT * FROM video_db.category_tb;
UPDATE category_tb
SET dateAdded = current_date();

SELECT * FROM video_db.penalty_cost;
SET SQL_SAFE_UPDATES = 0;
USE video_db; 
UPDATE penalty_cost
SET Hot = 14, Medium = 10, Low = 6;
SET SQL_SAFE_UPDATES = 1;
INSERT INTO penalty_cost (Hot, Medium, Low)
VALUES (4, 8, 12);
SET SQL_SAFE_UPDATES = 1;
SHOW TABLE STATUS WHERE Name = 'movies';
SELECT * FROM video_db.rentals;
USE video_db; 
INSERT INTO rentals (CopyID, memberID, employeeID, rentalTime)
VALUES (2, 1, 1, '2017-04-24');
ALTER TABLE renting_cost AUTO_INCREMENT = 2;

CREATE DEFINER=`root`@`localhost` TRIGGER `video_db`.`rentals_BEFORE_UPDATE` 
BEFORE UPDATE ON `rentals`
FOR EACH ROW
BEGIN
	UPDATE members
	-- INNER JOIN rentals ON members.memberID = rentals.memberID
	SET members.currentlyHiring = IF(NEW.currentlyHiring <> OLD.currentlyHiring,
	NEW.currentlyHiring, OLD.currentlyHiring);
END

INSERT INTO rentals (CopyID, memberID, employeeID, rentalTime, currentlyHiring)
VALUES (71, 4, 1, DATE(NOW() + INTERVAL 2 day), 1);
SELECT DISTINCT memberID
FROM rentals
WHERE currentlyHiring = 1;
INSERT INTO video_db.members(city, lastName, email) (SELECT first_name, last_name, email FROM sakila.customer LIMIT 100);
ALTER TABLE `video_db`.`test` 
ADD COLUMN `memberID` INT(11) NOT NULL AUTO_INCREMENT FIRST,
ADD PRIMARY KEY (`memberID`);

ALTER TABLE `video_db`.`test` 
DROP COLUMN `street`;

USE video_db;
DROP TABLE test2;
CREATE TABLE test2 (
    -- zip VARCHAR(10),
    memberID INT(11) NOT NULL auto_increment,
    street VARCHAR(50),
    primary key(memberID));
    -- number VARCHAR(10));
    
INSERT INTO video_db.test2(street, zip, number) (SELECT address, postal_code, city_id FROM sakila.address WHERE address_id % 6 = 0);

UPDATE members (SELECT city FROM sakila.city WHERE city_id % 6 = 0);

USE video_db;
SET SQL_SAFE_UPDATES = 0;
UPDATE members
INNER JOIN test ON (members.memberID = test.memberID)
SET members.zip = test.zip,
members.number = test.number;

SET SQL_SAFE_UPDATES = 1;
SELECT RIGHT (street, 10) FROM test;
select substr(street,5,length(street)) from test;
USE video_db;
SET SQL_SAFE_UPDATES = 0;
INSERT INTO video_db.test2(street) (select substr(street,5,length(street)) from test);
SET SQL_SAFE_UPDATES = 1;
SELECT LTRIM(street) FROM test2;