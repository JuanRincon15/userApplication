
CREATE OR REPLACE FUNCTION insert_department(p_name VARCHAR,contry_id INT)
RETURNS INT  AS $$
DECLARE
    new_id INT;
BEGIN
    INSERT INTO "Department" ("Name","CountryID") VALUES (p_name,contry_id)
	RETURNING "ID" INTO new_id;
    RETURN new_id;
END;
$$ LANGUAGE plpgsql;
