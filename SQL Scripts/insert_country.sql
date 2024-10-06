CREATE OR REPLACE FUNCTION insert_country(p_name VARCHAR)
RETURNS VOID AS $$
BEGIN
    INSERT INTO "Country" ("Name") VALUES (p_name);
END;
$$ LANGUAGE plpgsql;