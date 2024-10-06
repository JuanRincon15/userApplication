CREATE OR REPLACE FUNCTION insert_department(p_name VARCHAR,contry_id INT)
RETURNS VOID AS $$
BEGIN
    INSERT INTO "Department" ("Name","CountryID") VALUES (p_name,contry_id);
END;
$$ LANGUAGE plpgsql;
