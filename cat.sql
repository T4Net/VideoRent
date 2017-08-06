SELECT * FROM video_db.category_tb;

INSERT INTO category_tb (movieID, category)
SELECT movieID, 'Hot' FROM movies;
SET SQL_SAFE_UPDATES = 0;
UPDATE category_tb SET penalty = '15';
SET SQL_SAFE_UPDATES = 1;
SET SQL_SAFE_UPDATES = 0;
UPDATE category_tb
SET category = 'Hot'
WHERE movieID=21;