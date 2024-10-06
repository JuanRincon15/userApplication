CREATE OR REPLACE FUNCTION insert_user(p_name VARCHAR,p_phone VARCHAR,p_address VARCHAR,municipality_id INT)
RETURNS VOID AS $$
BEGIN
    INSERT INTO "User" ("Name","Phone","Address","MunicipalityID") VALUES (p_name,p_phone,p_address,municipality_id);
END;
$$ LANGUAGE plpgsql;



