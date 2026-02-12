/*BEGIN
    FOR t IN (SELECT table_name FROM user_tables) LOOP
        BEGIN
            -- Drop table with CASCADE CONSTRAINTS to remove dependent constraints
            EXECUTE IMMEDIATE 'DROP TABLE "' || t.table_name || '" CASCADE CONSTRAINTS';
        EXCEPTION
            WHEN OTHERS THEN
                -- Log any errors without stopping the loop
                DBMS_OUTPUT.PUT_LINE('Failed to drop table ' || t.table_name || ': ' || SQLERRM);
        END;
    END LOOP;
END;*/