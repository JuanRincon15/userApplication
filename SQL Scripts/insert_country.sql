CREATE OR REPLACE FUNCTION insert_country(p_name VARCHAR)
RETURNS INT 
LANGUAGE plpgsql
AS $$
DECLARE
    new_id INT;
BEGIN
    INSERT INTO "Country" ("Name") VALUES (p_name)
    RETURNING "ID" INTO new_id;
    RETURN new_id;
END;
$$;